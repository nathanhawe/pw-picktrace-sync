using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickTraceSync.Tests
{
	internal static class ConfigurationHelper
	{
		internal static IConfigurationRoot GetIConfigurationRoot()
		{
			var builder = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", true)
				.AddUserSecrets(System.Reflection.Assembly.GetAssembly(typeof(PickTraceSync.Program)));

			return builder.Build();
		}
	}
}
