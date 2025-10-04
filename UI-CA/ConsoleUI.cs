using FarmManagement.BL;
using FarmManagement.BL.Domain;
namespace CA;

public class ConsoleUI
{
    
    private readonly IManager _mgr;

    public ConsoleUI(IManager manager)
    {
        _mgr = manager;
    }
   

    public void Run()
    {
      

        bool running = true;

        Console.WriteLine("Welcome to the Farm Management Project");

        while (running)
        {
            ShowMenu();
            string input = Console.ReadLine();
            Console.WriteLine();

            if (!Int32.TryParse(input, out int choice))
            {
                Console.WriteLine("Please enter a valid choice.");
                continue;
            }

            switch (choice)
            {
                case 0:
                    running = false;
                    break;
                case 1:
                    ShowAllFarms();
                    break;
                case 2:
                    FilterFarms();
                    break;
                case 3:
                    ShowAllAnimals();
                    break;
                case 4:
                    FilterAnimals();
                    break;
            }
        }
    }

    

    private void ShowAllFarms()
    {
        Console.WriteLine("All Farms");
        Console.WriteLine("=========");
        foreach (Farm farm in _mgr.GetAllFarms())
        {
            Console.WriteLine(farm);
        }

        Console.WriteLine();
    }

    private void FilterFarms()
    {
        List<Farm> filtered = new List<Farm>();
        Console.Write("Enter location: ");
        string location = Console.ReadLine();

        foreach (Farm farm in _farms)
        {
            if (farm.Location.IndexOf(location, StringComparison.OrdinalIgnoreCase) >= 0) // niet case sensitive
            {
                filtered.Add(farm);
            }
        }

        if (filtered.Count == 0)
        {
            Console.WriteLine("No farms found in {0}", location);
        }
        else
        {
            foreach (Farm farm in filtered)
            {
                Console.WriteLine(farm);
            }
        }

        Console.WriteLine();
    }

    private void ShowAllAnimals()
    {
        Console.WriteLine("All Animals");
        Console.WriteLine("===========");

        foreach (Animal animal in _animals)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine();
    }

    private void FilterAnimals()
    {
        Console.Write("Type: ");
        AnimalType[] types = (AnimalType[])Enum.GetValues(typeof(AnimalType));
        for (int i = 0; i < types.Length; i++)
        {
            Console.Write($"{(int)types[i]}={types[i]}");
            if (i < types.Length - 1)
                Console.Write(", ");
        }

        Console.Write(": ");

        string typeInput = Console.ReadLine();

        int? typeResult = null;

        if (!string.IsNullOrEmpty(typeInput))
        {
            if (int.TryParse(typeInput, out int type) && (type >= 0 && type < types.Length))
            {
                typeResult = type;
            }
            else
            {
                Console.WriteLine("Please enter an number between 0 and " + types.Length);
                Console.WriteLine();
                return;
            }
        }

        Console.Write("Enter minimum livespan or leave blank:");
        string livespanInput = Console.ReadLine();

        double? minimumLivespan = null;

        if (!string.IsNullOrWhiteSpace(livespanInput))
        {
            if (double.TryParse(livespanInput, out double parsedLivespan))
            {
                minimumLivespan = parsedLivespan;
            }
            else
            {
                Console.WriteLine("Please enter a valid number for livespan.");
                Console.WriteLine();
                return;
            }
        }

        foreach (Animal animal in _animals)
        {
            bool matchesType = !typeResult.HasValue || (int)animal.Type == typeResult.Value;
            bool matchesLifespan = !minimumLivespan.HasValue || animal.Lifespan >= minimumLivespan.Value;

            if (matchesType && matchesLifespan)
            {
                Console.WriteLine(animal);
            }
        }

        Console.WriteLine();
    }

    private void ShowMenu()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("0) Quit");
        Console.WriteLine("1) Show all farms");
        Console.WriteLine("2) Show farms from location");
        Console.WriteLine("3) Show all animals");
        Console.WriteLine("4) Show all animals of type and/or minimum lifespan");

        Console.Write("Choice (0-4): ");
    }
}