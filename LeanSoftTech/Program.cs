using LeanSoftTech.Util;
using LeanSoftTech.Models;
using LeanSoftTech;

internal class Program
{
    private static void Main(string[] args)
    {

		var filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);		
		PersonGenerate personGenerate = new PersonGenerate(10000); // Generate persons. 10.000 - amount
        var data = personGenerate.Persons;
		SaveFile<List<Person>>.SaveAsJson(data, filepath);
		personGenerate.Persons = null;
		
		ReadJson<Person> readJson = new ReadJson<Person>(filepath + @"\Persons.json");

		PersonsConsole personsConsole = new PersonsConsole(readJson.JsonToList());
		personsConsole.WriteInfo(); 

		Console.WriteLine(); 
	}
}