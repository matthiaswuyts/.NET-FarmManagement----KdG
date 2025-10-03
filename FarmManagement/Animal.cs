namespace FarmManagement;

public class Animal
{
    
    public double AverageWeight { get; set; }
    public AnimalType Type { get; set; }
    public int Lifespan { get; set; }
    
    public string Species { get; set; }
    public ICollection<Farm> Farms { get; set; }

    public Animal(string species, int lifespan, double averageWeight, AnimalType type)
    {
        Species = species;
        Lifespan = lifespan;
        AverageWeight = averageWeight;
        Type = type;
        Farms = new List<Farm>();
    }


    public override string ToString()
    {
        return $"{Type} (Species: {Species}), Lifespan: {Lifespan} yrs, Avg. weight: {AverageWeight} kg";
    }

    
    
    public void AddFarm(Farm farm)
    {
        // Ensure this farm is not already linked to the animal
        if (!Farms.Contains(farm))
        {
            // Link the farm to the animal
            Farms.Add(farm);

            // Ensure the animal is also linked to the farm
            if (!farm.Animals.Contains(this))
            {
                farm.Animals.Add(this);
            }
        }
    }



}