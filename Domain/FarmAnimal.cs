using System.ComponentModel.DataAnnotations;

namespace FarmManagement.BL.Domain;

public class FarmAnimal
{
    public Farm Farm { get; set; }
    public Animal Animal { get; set; }
    public int Count { get; set; }
}