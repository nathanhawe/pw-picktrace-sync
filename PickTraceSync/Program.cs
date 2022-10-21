using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PickTraceSync.Data;
using PickTraceSync.Data.PickTraceApi;
using PickTraceSync.Service;
using Serilog;
using Serilog.Formatting.Json;
using HttpClientHandler = PickTraceSync.Data.PickTraceApi.HttpClientHandler;

namespace PickTraceSync
{
	public class Program
	{
#if DEBUG
		public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", true)
			.AddUserSecrets<Program>()
			.Build();
#else
		public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", true)
			.Build();
#endif
		static void Main(string[] args)
		{
			Log.Logger = new LoggerConfiguration()
				.ReadFrom.Configuration(Configuration)
				.CreateLogger();

			using IHost host = Host
				.CreateDefaultBuilder(args)
				.ConfigureServices((_, services) =>
				{
					services.AddDbContext<PrimaDwContext>(opt =>
						opt.UseSqlServer(
							Configuration.GetConnectionString("DWConnection")
							, sqlServerOptionsAction: sqlOptions =>
							{
								sqlOptions.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null);
							}
						)
					);
					services.AddSingleton<IHttpHandler, HttpClientHandler>();
					services.AddSingleton<IPickTraceAuthenticator>(x =>
						ActivatorUtilities.CreateInstance<PickTraceAuthenticator>(
							x, 
							Configuration["PickTrace:Username"], 
							Configuration["PickTrace:Password"], 
							Configuration["PickTrace:OrgId"]
						)
					);
					services.AddScoped<IPickTracePayrollExportsSearch, PickTracePayrollExportsSearch>();
					services.AddScoped<IDateSynchronizationService, DateSyncService>();
				})
				.UseSerilog()
				.Build();


			Log.Logger.Information("Application started.");
			var syncService = host.Services.GetService<IDateSynchronizationService>();

			if (args.Length == 0)
			{
				// Default execution, run for today's date.
				Console.WriteLine("Default");
				syncService.SynchronizeDate(DateTime.Now);

				return;
			}
			
			if(args.Length == 2)
			{
				DateTime startDate, endDate;

				if (!DateTime.TryParse(args[0], out startDate))
				{
					Console.WriteLine($"Could not parse date from string '{args[0]}'.");
					return;
				}

				if (!DateTime.TryParse(args[1], out endDate))
				{
					Console.WriteLine($"Could not parse date from string '{args[1]}'.");
					return;
				}

				if(startDate > endDate)
				{
					Console.WriteLine($"Invalid date order, start date '{startDate}' is after end date '{endDate}'.");
					return;
				}

				// Execute for date range
				syncService.SynchronizeDateRange(startDate, endDate);
				return;
			}
			

			// Require one or more dates
			Console.WriteLine("This application expects either no parameters (to run for previous day) or two date parameters to indicate a range.");
			return;

		}
	}
}