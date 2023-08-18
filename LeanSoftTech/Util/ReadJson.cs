using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeanSoftTech.Util
{
	public class ReadJson<T>
	{
		private readonly string _json;
        public ReadJson(string filepath)
        {
            using (StreamReader sr = new StreamReader(filepath))
			{
				_json = sr.ReadToEnd();
			}
        }
        public List<T> JsonToList()
		{

			var list = JsonSerializer.Deserialize<List<T>>(_json);
			return list;
		}
	}
}
