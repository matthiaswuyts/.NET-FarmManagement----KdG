namespace FarmManagement.BL.Domain;

public class Harvest
{
    private static int _nextId = 1;
    public int Id { get; private set; }
    public CropType CropType { get; set; }
    public DateOnly HarvestDate { get; set; }
    public double Quantity { get; set; }
    public Farm Farm { get; set; }

    public Harvest(CropType cropType, DateOnly harvestDate, double quantity, Farm farm)
    {
        Id = _nextId++;
        CropType = cropType;
        HarvestDate = harvestDate;
        Quantity = quantity;
        Farm = farm;
    }


    public override string ToString()
    {
        return $"{CropType} harvest on {HarvestDate.ToShortDateString()} ({Quantity} kg)";
    }

}