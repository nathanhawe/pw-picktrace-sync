using System;
using Microsoft.Extensions.Configuration;

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
		}
	}
}