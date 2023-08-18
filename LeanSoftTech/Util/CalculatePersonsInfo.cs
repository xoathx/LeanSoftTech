using LeanSoftTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanSoftTech.Util
{
	public class CalculatePersonsInfo
	{
        public int PersonsCount;
        public int PersonsCreditCardCount;
        public int AverageChildAge;

        private readonly List<Person> _persons;
        public CalculatePersonsInfo(List<Person> data)
        {
            _persons = data;
            PersonsCount = data.Count;
        }

        private void CalculateInfo()
        {
            int totalChildren = 0;
            foreach (Person person in _persons)
            {
                PersonsCreditCardCount += person.CreditCardNumbers.Length;
                totalChildren += person.Children.Length;
                //TODO average age
            }
        }
    }
}
