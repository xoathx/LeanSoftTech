using LeanSoftTech.Models;
using LeanSoftTech.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanSoftTech
{
	public class PersonGenerate
	{
        public List<Person> Persons { get; set; }
        public PersonGenerate(int count)
        {
            Persons = new List<Person>();

			for (int i = 0; i < count; i++)
			{
				Person person = new Person()
				{
					Id = i,
					TransportId = Generator.GenerateGuid(),
					FirstName = Generator.GenerateFirstName(),
					LastName = Generator.GenerateLastName(),
					SequenceId = Generator.GenerateSequenceId(),
					CreditCardNumbers = Generator.GenerateCardCreditNumbers(),
					Age = Generator.GenerateAge(),
					Phones = Generator.GeneratePhones(),
					BirthDate = Generator.GenerateBirthDate(),
					Salary = Generator.GenerateSalary(),
					IsMarred = Generator.GenerateIsMarried(),
					Gender = Generator.GenerateGender(),
					Children = Generator.GenerateChild()
				};
				Persons.Add(person);
			}
		}
    }
}
