using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PickTraceSync.Data;

namespace PickTraceSync
{
	public class Program
	{
		public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", true)
			.AddUserSecrets<Program>()
			.Build();

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			using IHost host = Host
				.CreateDefaultBuilder(args)
				.ConfigureServices((_, services) =>
					services.AddDbContext<PrimaDwContext>(opt =>
						opt.UseSqlServer(
							Configuration.GetConnectionString("DWConnection")
							, sqlServerOptionsAction: sqlOptions =>
							{
								sqlOptions.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null);
							}
						)
					))
				.Build();
		}
	}
}