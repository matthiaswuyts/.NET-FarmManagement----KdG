using FarmManagement.BL;
using FarmManagement.DAL;
using CA;


DummyDataSeeder seeder = new DummyDataSeeder();
seeder.Seed();

IRepository repository = new InMemoryRepository();
IManager manager = new Manager(repository);
ConsoleUI consoleUi = new ConsoleUI(manager);
consoleUi.Run();    