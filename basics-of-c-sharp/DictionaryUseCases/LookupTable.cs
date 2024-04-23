namespace BasicsOfCSharp.DictionaryUseCases;

public class LookupTable
{
    public static void ExecuteMethod()
    {
        Dictionary<string, string> countryCodes = new();

        bool continueLoop = true;
        while (continueLoop)
        {
            Console.WriteLine("\tPress: \n\t 1 for 'Add' \n\t 2 for display values \n\t 3 for search \n\t 4 For exit ");
            var key = Console.ReadKey();
            Console.WriteLine("....................................");

            switch (key.KeyChar)
            {
                // add
                case '1':
                    {
                        AddCountry();
                        break;
                    }
                // display countries
                case '2':
                    {
                        DisplayCountries();
                        break;
                    }

                // search
                case '3':
                    {
                        FindCountry();
                        break;
                    }

                // exit
                case '4':
                    {
                        continueLoop = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please select the valid option.");
                        break;
                    }
            }
            Console.WriteLine("...............\n");
        }

        void AddCountry()
        {
            Console.WriteLine("Add The country name: ");
            string countryName = Console.ReadLine();
            Console.WriteLine("Add The country code: ");
            string countryCode = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(countryName) && !string.IsNullOrWhiteSpace(countryCode))
            {
                countryCodes[countryName] = countryCode;
            }
            else
            {
                Console.WriteLine("invalid country name or code.");
            }
        }

        void DisplayCountries()
        {
            Console.WriteLine("Country\tiso code");
            Console.WriteLine("....................................");
            foreach (var kvp in countryCodes)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }
            Console.WriteLine();
        }

        void FindCountry()
        {
            Console.WriteLine("Type country name to get iso code: ");
            string country = Console.ReadLine();
            if (countryCodes.TryGetValue(country, out string countryCode))
            {
                Console.WriteLine($"ISO Code of {country} is {countryCode}");
            }
            else
            {
                Console.WriteLine($"Country code for {country} does not found");
            }
        }
    }
}
