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
        public int PersonsCount { get; set; }
        public int PersonsCreditCardCount { get; set; }
        public int AverageChildAge { get; set; }

        private readonly List<Person> _persons;
        public CalculatePersonsInfo(List<Person> data)
        {
            _persons = data;
            PersonsCount = data.Count;
            CalculateInfo();
        }

        private void CalculateInfo()
        {
            int totalChildren = 0;
            int totalAge = 0;
            foreach (Person person in _persons)
            {
                PersonsCreditCardCount += person.CreditCardNumbers.Length;
                totalChildren += person.Children.Length;
                for(int i = 0; i < person.Children.Length; i++)
                {
                    TimeSpan timeSpan = TimeSpan.FromSeconds(person.Children[i].BirthDate);
                    totalAge += timeSpan.Days / 365; 
                }
            }
            AverageChildAge = totalAge / totalChildren;
        }
    }
}
