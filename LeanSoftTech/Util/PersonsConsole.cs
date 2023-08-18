using LeanSoftTech.Models;

namespace LeanSoftTech.Util
{
	public class PersonsConsole
	{
        private readonly List<Person> _list;
        private readonly CalculatePersonsInfo _calculatePersonsInfo;
        public PersonsConsole(List<Person> persons)
        {
            _list = persons;
            _calculatePersonsInfo = new CalculatePersonsInfo(persons);
        }

        public void WriteInfo()
        {
            Console.WriteLine("           = LeanSoft | Test task -           ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Persons count: " + _list.Count);
			Console.WriteLine("Persons credit card count: " + _calculatePersonsInfo.PersonsCreditCardCount);
			Console.WriteLine("Average value of child age: " + _calculatePersonsInfo.AverageChildAge);
			Console.WriteLine("----------------------------------------------");
		}
        
        

    }
}
