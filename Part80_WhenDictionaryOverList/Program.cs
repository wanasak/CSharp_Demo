using System;
using System.Collections.Generic;

// Find method of the list loops thru each object in the list
// Dictionary find object by key

namespace Part81_WhenDictionaryOverList
{
    class Country 
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
			Country country1 = new Country()
			{
				Code = "AUS",
				Name = "AUSTRALIA",
				Capital = "Canberra"
			};

			Country country2 = new Country()
			{
				Code = "IND",
				Name = "INDIA ",
				Capital = "New Delhi"
			};

			Country country3 = new Country()
			{
				Code = "USA",
				Name = "UNITED STATES",
				Capital = "Washington D.C."
			};

			Country country4 = new Country()
			{
				Code = "GBR",
				Name = "UNITED KINGDOM",
				Capital = "London"
			};

			Country country5 = new Country()
			{
				Code = "CAN",
				Name = "CANADA",
				Capital = "Ottawa"
			};

            //List<Country> listCountries = new List<Country>();
            //listCountries.Add(country1);
            //listCountries.Add(country2);
            //listCountries.Add(country3);
            //listCountries.Add(country4);
            //listCountries.Add(country5)

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
			dictionaryCountries.Add(country1.Code, country1);
			dictionaryCountries.Add(country2.Code, country2);
			dictionaryCountries.Add(country3.Code, country3);
			dictionaryCountries.Add(country4.Code, country4);
			dictionaryCountries.Add(country5.Code, country5);

            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code");
                string inputCountryCode = Console.ReadLine().ToUpper();

                // list
                //Country resultCountry = listCountries.Find(c => c.Code == inputCountryCode);
                // dictionary
                Country resultCountry = dictionaryCountries[inputCountryCode];

                if (resultCountry == null)
                    Console.WriteLine("The country code you entered does not found.");
                else
                {
                    userChoice = resultCountry.Name;
                    Console.WriteLine($"Name: {resultCountry.Name}");
                    Console.WriteLine($"Capital: {resultCountry.Capital}");
                }
            }
            while (string.IsNullOrEmpty(userChoice));
        }
    }
}
