using FarmManagement.BL.Domain;

namespace FarmManagement.UI.CA.Extensions;

public static class AnimalExtensions
{
    public static string GetInfo(this Animal animal)
    {
        var info = $"{animal.Type} (Species: {animal.Species}), Lifespan: {animal.Lifespan} yrs, Avg. weight: {animal.AverageWeight} kg";

        if (animal.FarmAnimals != null && animal.FarmAnimals.Any())
        {
            foreach (var fa in animal.FarmAnimals)
            {
                info += $"\n  - {fa.Farm?.Name ?? "UNKNOWN"}: {fa.Count} {animal.Species} {animal.Type}{(fa.Count > 1 ? "s" : "")}";
            }
        }
        else
        {
            info += "\n  - No farms";
        }

        return info;
    }

}