using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;

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

    }
}
