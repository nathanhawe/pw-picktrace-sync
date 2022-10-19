using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PickTraceSync.Data
{
	public class CustomDecimalConverter : JsonConverter<decimal>
	{
		public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			
			if(reader.TokenType == JsonTokenType.String)
			{
				if (decimal.TryParse(reader.GetString(), out decimal result))
				{
					return result;
				}
				return 0;
			}
			return reader.GetDecimal();
			
		}

		public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(value);
		}
	}
}
