using FarmManagement.BL.Domain;
using FarmManagement.DAL;


namespace FarmManagement.BL;

public class Manager : IManager
{
    private readonly IRepository _repository;
    
    public Manager(IRepository repository)
    {
        _repository = repository;
    }

    public Farm GetFarm(int id)
    {
        return _repository.ReadFarm(id);
    }

    public IEnumerable<Farm> GetAllFarms()
    {
        return _repository.ReadAllFarms();
    }

    public IEnumerable<Farm> GetFarmsByLocation(string location)
    {
        return _repository.ReadFarmsByLocation(location);
    }

    public Farm AddFarm(string name, string location, int sizeInHectares, int establisedYear)
    {
        Farm farm = new Farm(name, location, sizeInHectares, establisedYear);
        _repository.CreateFarm(farm);
        return farm;
    }

    public Animal GetAnimal(int id)
    {
        return _repository.ReadAnimal(id);
    }

    public IEnumerable<Animal> GetAllAnimals()
    {
        return _repository.ReadAllAnimals();
    }

    public IEnumerable<Animal> GetAnimalsByTypeAndLifespan(int? type, int? lifespan)
    {
        return _repository.ReadAnimalsByTypeAndLifespan(type, lifespan);
    }

    public Animal AddAnimal(string species, int lifespan, double averageWeight, AnimalType type)
    {
        Animal animal = new Animal(species,lifespan,averageWeight,type);
        _repository.CreateAnimal(animal);
        return animal;
    }
}