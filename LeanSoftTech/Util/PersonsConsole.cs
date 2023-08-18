using LeanSoftTech.Models;

namespace LeanSoftTech.Util
{
	internal class PersonsConsole
	{
        private readonly List<Person> _list;
        public PersonsConsole(List<Person> persons)
        {
            _list = persons;
        }

        public void WriteInfo()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Persons count: " + _list.Count);
			Console.WriteLine("Persons credit card count: " );
			Console.WriteLine("Average value of child age: ");
			Console.WriteLine("----------------------------------------------");
		}
        
        

    }
}
