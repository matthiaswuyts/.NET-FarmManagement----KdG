using FarmManagement.BL.Domain;
namespace FarmManagement.DAL;

public class DummyDataSeeder
{
    public void Seed()
    {
        // Farms
        Farm sunnyMeadowFarm = new Farm(1,"Sunny Meadow Farm", "Netherlands", 1995, 50);
        Farm greenValleyEstate = new Farm(2,"Green Valley Estate", "Belgium", 2000, 74.2);
        Farm oldOakHomestead = new Farm(3,"Old Oak Homestead", "Germany", 1980);
        Farm riverbendFarmstead = new Farm(4,"Riverbend Farmstead", "Netherlands", 2010, 60);
        

        // Adding to list
        InMemoryRepository.Farms.AddRange(new Farm[] { sunnyMeadowFarm, greenValleyEstate, oldOakHomestead, riverbendFarmstead });
        // Animals
        Animal holsteinCow = new Animal(1,"Holstein", 10, 500, AnimalType.Cow);
        Animal jerseyCow = new Animal(2,"Jersey", 12, 520, AnimalType.Cow);
        Animal angusCow = new Animal(3,"Angus", 11, 540, AnimalType.Cow);

        Animal berkshirePig = new Animal(4,"Berkshire", 5, 200, AnimalType.Pig);
        Animal largeWhitePig = new Animal(5,"Large White", 6, 250, AnimalType.Pig);
        Animal durocPig = new Animal(6,"Duroc", 4, 220, AnimalType.Pig);

        Animal silkieChicken = new Animal(7,"Silkie", 2, 1.5, AnimalType.Chicken);
        Animal leghornChicken = new Animal(8,"Leghorn", 3, 1.8, AnimalType.Chicken);
        Animal rhodeIslandChicken = new Animal(9,"Rhode Island", 2, 2, AnimalType.Chicken);

        Animal merinoSheep = new Animal(10,"Merino", 8, 70, AnimalType.Sheep);
        Animal suffolkSheep = new Animal(11,"Suffolk", 9, 75, AnimalType.Sheep);

        Animal alpineGoat = new Animal(12,"Alpine", 9, 65, AnimalType.Goat);
        Animal boerGoat = new Animal(13,"Boer", 8, 68, AnimalType.Goat);

        Animal friesianHorse = new Animal(14,"Friesian", 15, 400, AnimalType.Horse);
        Animal arabianHorse = new Animal(15,"Arabian", 12, 380, AnimalType.Horse);
        Animal thoroughbredHorse = new Animal(16,"Thoroughbred", 14, 420, AnimalType.Horse);



        InMemoryRepository.Animals.AddRange(new Animal[]
        {
            holsteinCow, jerseyCow, angusCow, berkshirePig, largeWhitePig, durocPig, silkieChicken, leghornChicken, rhodeIslandChicken, merinoSheep, suffolkSheep, alpineGoat, boerGoat, friesianHorse, arabianHorse, thoroughbredHorse
        });


       // Linking
        holsteinCow.ConnectToFarm(sunnyMeadowFarm);
        jerseyCow.ConnectToFarm(sunnyMeadowFarm); 
        jerseyCow.ConnectToFarm(greenValleyEstate);
        angusCow.ConnectToFarm(greenValleyEstate);

        berkshirePig.ConnectToFarm(sunnyMeadowFarm);
        largeWhitePig.ConnectToFarm(greenValleyEstate); 
        largeWhitePig.ConnectToFarm(oldOakHomestead);
        durocPig.ConnectToFarm(oldOakHomestead);

        silkieChicken.ConnectToFarm(oldOakHomestead);
        leghornChicken.ConnectToFarm(riverbendFarmstead);
        rhodeIslandChicken.ConnectToFarm(greenValleyEstate);

        merinoSheep.ConnectToFarm(greenValleyEstate);
        suffolkSheep.ConnectToFarm(riverbendFarmstead);

        alpineGoat.ConnectToFarm(sunnyMeadowFarm);
        boerGoat.ConnectToFarm(oldOakHomestead);

        friesianHorse.ConnectToFarm(riverbendFarmstead);
        arabianHorse.ConnectToFarm(greenValleyEstate);
        thoroughbredHorse.ConnectToFarm(sunnyMeadowFarm);


        // harvests
      
        sunnyMeadowFarm.Harvests.Add(new Harvest(1,CropType.Carrot, new DateOnly(2019, 4, 15), 28000.75, sunnyMeadowFarm));
        sunnyMeadowFarm.Harvests.Add(new Harvest(2,CropType.Wheat, new DateOnly(2020, 7, 18), 13500.40, sunnyMeadowFarm));
        sunnyMeadowFarm.Harvests.Add(new Harvest(3,CropType.Corn, new DateOnly(2021, 6, 5), 4500.20, sunnyMeadowFarm));


        greenValleyEstate.Harvests.Add(new Harvest(4,CropType.Tomato, new DateOnly(2019, 6, 30), 9200.00, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(5,CropType.Carrot, new DateOnly(2020, 8, 25), 11000.90, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(6,CropType.Lettuce, new DateOnly(2021, 9, 10), 8800.60, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(7,CropType.Wheat, new DateOnly(2022, 10, 12), 7000.30, greenValleyEstate));
        greenValleyEstate.Harvests.Add(new Harvest(8,CropType.Potato, new DateOnly(2022, 9, 5), 12000.00, greenValleyEstate));

        oldOakHomestead.Harvests.Add(new Harvest(9,CropType.Lettuce, new DateOnly(2019, 5, 22), 6700.80, oldOakHomestead));
        oldOakHomestead.Harvests.Add(new Harvest(10,CropType.Potato, new DateOnly(2020, 10, 14), 14500.25, oldOakHomestead));
        oldOakHomestead.Harvests.Add(new Harvest(11,CropType.Corn, new DateOnly(2021, 9, 2), 16000.00, oldOakHomestead));
        oldOakHomestead.Harvests.Add(new Harvest(12,CropType.Wheat, new DateOnly(2022, 7, 28), 9300.55, oldOakHomestead));
        
        riverbendFarmstead.Harvests.Add(new Harvest(13,CropType.Lettuce, new DateOnly(2019, 6, 12), 8700.40, riverbendFarmstead));
        riverbendFarmstead.Harvests.Add(new Harvest(14,CropType.Apple, new DateOnly(2020, 9, 21), 12500.75, riverbendFarmstead));
        riverbendFarmstead.Harvests.Add(new Harvest(15,CropType.Tomato, new DateOnly(2021, 10, 5), 5800.10, riverbendFarmstead));

    }
}