using FarmManagement.BL.Domain;

namespace FarmManagement.UI.CA.Extensions;

public static class HarvestExtensions
{
    public static string GetInfo(this Harvest harvest)
    {
        return $"{harvest.CropType} on {harvest.HarvestDate}: {harvest.Quantity} kg";
    }

}