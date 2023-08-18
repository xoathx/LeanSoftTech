using LeanSoftTech.Util;
using LeanSoftTech.Models;
using LeanSoftTech;

internal class Program
{
    private static void Main(string[] args)
    {
		var filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	/*	PersonGenerate personGenerate = new PersonGenerate(3);
		var data = personGenerate.Persons;
		SaveFile<List<Person>>.SaveAsJson(data, filepath);
		personGenerate.Persons.Clear(); */
		
		ReadJson<Person> readJson = new ReadJson<Person>(filepath + @"\Persons.json");
		Console.WriteLine();
	}
}