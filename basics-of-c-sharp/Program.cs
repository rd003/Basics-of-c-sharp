// Lookup table

Dictionary<string, string> countryCodes = new();

bool continueLoop = true;
while (continueLoop)
{
    Console.WriteLine(@"\n Press: \n\t 1 for 'Add' \n\t 2 for display values \n\t 3 for search \n\t 4 For exit ");
    var key = Console.ReadKey();

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

                break;
            }

        // search
        case '3':
            {

                break;
            }

        // find
        case '4':
            {

                break;
            }
        default:
            {
                Console.WriteLine("Please select the valid option.");
                break;
            }
    }
}

void AddCountry()
{
    Console.WriteLine("Add The country name: ");
    string countryName = Console.ReadLine();
    Console.WriteLine("Add The country code: ");
    string countryCode = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(countryName) && string.IsNullOrWhiteSpace(countryCode))
    {
        countryCodes[countryName] = countryCode;
    }
    else
    {
        Console.WriteLine("invalid country name or code.");
    }
}
