using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LeanSoftTech.Util
{
	public static class SaveFile<T>
	{
		public async static void SaveAsJson(T data, string path)
		{
			var serializeOptions = new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
				WriteIndented = true
			};

			await using FileStream stream = File.Create(path + @"\" + "Persons.json");
			await JsonSerializer.SerializeAsync(stream, data, serializeOptions);

            await Console.Out.WriteLineAsync("Json saved");
        }
	}
}
