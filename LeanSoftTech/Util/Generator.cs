using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using LeanSoftTech.Models;

namespace LeanSoftTech.Util
{
    static class Generator
    {

        public static Guid GenerateGuid()
        {
            return Guid.NewGuid();
        }

        public static string GenerateFirstName()
        {

            return Faker.Name.First();
        }

        public static string GenerateLastName()
        {
            return Name.Last();
        }

        public static int GenerateSequenceId()
        {
            Random random = new Random();
            return random.Next(0, 10000);
        }

        public static string[] GenerateCardCreditNumbers()
        {
            
            Random random = new Random();
            int count = random.Next(1, 10);

            List<string> cards = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string card = string.Empty;
                for(int j = 0; j < 4; j++) 
                {
                    card += random.Next(1000, 9999).ToString();
                }
                cards.Add(card);
            }
            return cards.ToArray();
        }

        public static int GenerateAge()
        {
            Random random = new Random();
            return (int)random.Next(19, 100);
        }
        
        public static string[] GeneratePhones()
        {
            Random random = new Random();
            int count = random.Next(1, 5);
            List<string> phones = new List<string>();

            for(int i = 0; i < count; i++)
            {
                phones.Add(Phone.Number());
            }
            return phones.ToArray();
        }

        public static long GenerateBirthDate()
        {
            Random random = new Random();

            var startDate = DateTimeOffset.UtcNow.AddYears(-50);
            var endDate = DateTimeOffset.UtcNow.AddYears(-5);

            int range = ((TimeSpan)(endDate - startDate)).Days;

            return startDate.AddDays(random.Next(range)).ToUnixTimeSeconds();
                  
        }

        public static double GenerateSalary()
        {
            Random random = new Random();

            return random.Next(20000, 150000);
        }

        public static bool GenerateIsMarried()
        {
            Random random = new Random();
            return random.NextDouble() >= 0.5;
        }

        public static Gender GenerateGender()
        {
            var random = new Random();

            return (Gender)random.Next(0, 1);
        }

        public static Child[] GenerateChild()
        {
            var random = new Random();

            int count = random.Next(0, 4);
            List<Child> children = new List<Child>(count);

            if(count == 0) 
            {
                return new Child[0];
            }
            for(int i = 1; i <= count; i++)
            {
                Child child = new Child()
                {
                    Id = i,
                    FirstName = GenerateFirstName(),
                    LastName = GenerateLastName(),
                    BirthDate = GenerateBirthDate(),
                    Gender = GenerateGender()
                };

                children.Add(child);
            }
            return children.ToArray();
        }
    }
}
