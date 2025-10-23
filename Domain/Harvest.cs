namespace FarmManagement.BL.Domain;

public class Harvest
{
    public int Id { get; set; }
    public CropType CropType { get; set; }
    public DateOnly HarvestDate { get; set; }
    public double Quantity { get; set; }
    public Farm Farm { get; set; }

    public Harvest(CropType cropType, DateOnly harvestDate, double quantity, Farm farm)
    {
        CropType = cropType;
        HarvestDate = harvestDate;
        Quantity = quantity;
        Farm = farm;
    }
    
}