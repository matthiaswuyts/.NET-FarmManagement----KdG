using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmManagement.BL.Domain;

public class FarmAnimal
{
    
    [Key][ForeignKey("Farm")]
    public int FkFarmId { get; set; }

    [Key][ForeignKey("Animal")]
    public int FkAnimalId { get; set; }
    public Farm Farm { get; set; }
    public Animal Animal { get; set; }
    public int Count { get; set; }
}