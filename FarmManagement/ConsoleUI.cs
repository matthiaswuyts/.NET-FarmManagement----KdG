namespace FarmManagement;

public class ConsoleUI
{
    private readonly List<Farm> _farms = new List<Farm>();
    private readonly List<Animal> _animals = new List<Animal>();

    public void Run()
    {
        Seed();

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

    private void Seed()
    {
        // Farms
        Farm sunnyMeadowFarm = new Farm("Sunny Meadow Farm", "Netherlands", 1995, 50);
        Farm greenValleyEstate = new Farm("Green Valley Estate", "Belgium", 2000, 74.2);
        Farm oldOakHomestead = new Farm("Old Oak Homestead", "Germany", 1980);
        Farm riverbendFarmstead = new Farm("Riverbend Farmstead", "Netherlands", 2010, 60);

        // Adding to list
        _farms.AddRange(new Farm[] { sunnyMeadowFarm, greenValleyEstate, oldOakHomestead, riverbendFarmstead });

        // Animals
        Animal holsteinCow = new Animal("Holstein", 10, 500, AnimalType.Cow);
        Animal jerseyCow = new Animal("Jersey", 12, 520, AnimalType.Cow);
        Animal angusCow = new Animal("Angus", 11, 540, AnimalType.Cow);

        Animal berkshirePig = new Animal("Berkshire", 5, 200, AnimalType.Pig);
        Animal largeWhitePig = new Animal("Large White", 6, 250, AnimalType.Pig);
        Animal durocPig = new Animal("Duroc", 4, 220, AnimalType.Pig);

        Animal silkieChicken = new Animal("Silkie", 2, 1.5, AnimalType.Chicken);
        Animal leghornChicken = new Animal("Leghorn", 3, 1.8, AnimalType.Chicken);
        Animal rhodeIslandChicken = new Animal("Rhode Island", 2, 2, AnimalType.Chicken);

        Animal merinoSheep = new Animal("Merino", 8, 70, AnimalType.Sheep);
        Animal suffolkSheep = new Animal("Suffolk", 9, 75, AnimalType.Sheep);

        Animal alpineGoat = new Animal("Alpine", 9, 65, AnimalType.Goat);
        Animal boerGoat = new Animal("Boer", 8, 68, AnimalType.Goat);

        Animal friesianHorse = new Animal("Friesian", 15, 400, AnimalType.Horse);
        Animal arabianHorse = new Animal("Arabian", 12, 380, AnimalType.Horse);
        Animal thoroughbredHorse = new Animal("Thoroughbred", 14, 420, AnimalType.Horse);



        _animals.AddRange(new Animal[]
        {
            holsteinCow, jerseyCow, angusCow, berkshirePig, largeWhitePig, durocPig, silkieChicken, leghornChicken, rhodeIslandChicken, merinoSheep, suffolkSheep, alpineGoat, boerGoat, friesianHorse, arabianHorse, thoroughbredHorse
        });


       // Linking
        holsteinCow.AddFarm(sunnyMeadowFarm);
        jerseyCow.AddFarm(sunnyMeadowFarm); 
        jerseyCow.AddFarm(greenValleyEstate);
        angusCow.AddFarm(greenValleyEstate);

        berkshirePig.AddFarm(sunnyMeadowFarm);
        largeWhitePig.AddFarm(greenValleyEstate); 
        largeWhitePig.AddFarm(oldOakHomestead);
        durocPig.AddFarm(oldOakHomestead);

        silkieChicken.AddFarm(oldOakHomestead);
        leghornChicken.AddFarm(riverbendFarmstead);
        rhodeIslandChicken.AddFarm(greenValleyEstate);

        merinoSheep.AddFarm(greenValleyEstate);
        suffolkSheep.AddFarm(riverbendFarmstead);

        alpineGoat.AddFarm(sunnyMeadowFarm);
        boerGoat.AddFarm(oldOakHomestead);

        friesianHorse.AddFarm(riverbendFarmstead);
        arabianHorse.AddFarm(greenValleyEstate);
        thoroughbredHorse.AddFarm(sunnyMeadowFarm);


        // harvests
      
        sunnyMeadowFarm.Harvests.Add(new Harvest(CropType.Carrot, new DateOnly(2019, 4, 15), 28000.75, sunnyMeadowFarm));
        sunnyMeadowFarm.Harvests.Add(new Harvest(CropType.Wheat, new DateOnly(2020, 7, 18), 13500.40, sunnyMeadowFarm));
        sunnyMeadowFarm.Harvests.Add(new Harvest(CropType.Corn, new DateOnly(2021, 6, 5), 4500.20, sunnyMeadowFarm));


        greenValleyEstate.Harvests.Add(new Harvest(CropType.Tomato, new DateOnly(2019, 6, 30), 9200.00, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(CropType.Carrot, new DateOnly(2020, 8, 25), 11000.90, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(CropType.Lettuce, new DateOnly(2021, 9, 10), 8800.60, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(CropType.Wheat, new DateOnly(2022, 10, 12), 7000.30, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(CropType.Potato, new DateOnly(2022, 9, 5), 12000.00, greenValleyEstate));

        oldOakHomestead.Harvests.Add(new Harvest(CropType.Lettuce, new DateOnly(2019, 5, 22), 6700.80, oldOakHomestead));
        oldOakHomestead.Harvests.Add(new Harvest(CropType.Potato, new DateOnly(2020, 10, 14), 14500.25, oldOakHomestead));
        oldOakHomestead.Harvests.Add(new Harvest(CropType.Corn, new DateOnly(2021, 9, 2), 16000.00, oldOakHomestead));
        oldOakHomestead.Harvests.Add(new Harvest(CropType.Wheat, new DateOnly(2022, 7, 28), 9300.55, oldOakHomestead));
        
        riverbendFarmstead.Harvests.Add(new Harvest(CropType.Lettuce, new DateOnly(2019, 6, 12), 8700.40, riverbendFarmstead));
        riverbendFarmstead.Harvests.Add(new Harvest(CropType.Apple, new DateOnly(2020, 9, 21), 12500.75, riverbendFarmstead));
        riverbendFarmstead.Harvests.Add(new Harvest(CropType.Tomato, new DateOnly(2021, 10, 5), 5800.10, riverbendFarmstead));

    }

    private void ShowAllFarms()
    {
        Console.WriteLine("All Farms");
        Console.WriteLine("=========");
        foreach (Farm farm in _farms)
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