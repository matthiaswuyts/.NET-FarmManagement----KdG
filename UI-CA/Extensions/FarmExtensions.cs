using FarmManagement.BL.Domain;

namespace CA.Extensions;

public static class FarmExtensions
{
    public static string GetInfo(this Farm farm)
    {
        return $"Farm: {farm.Name} (ID: {farm.Id}) located in {farm.Location} with {(farm.SizeInHectares.HasValue ? $"{farm.SizeInHectares} hectares" : "unknown size of hectares")}. Founded in {farm.EstablishedYear} with {farm.Harvests.Count} harvests and {farm.Animals.Count} animals.";
    }
}