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
		public static void SaveAsJson(T data, string path)
		{
			var serializeOptions = new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
				WriteIndented = true
			};
			string filepath = path + @"\" + "Persons.json";

            string json = JsonSerializer.Serialize(data, serializeOptions);
			File.WriteAllText(filepath, json);
        }
	}
}
