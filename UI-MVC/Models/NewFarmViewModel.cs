using System.ComponentModel.DataAnnotations;

namespace FarmManagement.UI.Web.Models;

public class NewFarmViewModel : IValidatableObject
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Location { get; set; }
    
    [Range(0.1, double.MaxValue)]
    public double? SizeInHectares { get; set; }
    
    [RegularExpression(@"^\d{4}$", ErrorMessage = "exactly 4 digits")]
    public int EstablishedYear { get; set; }
    
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        List<ValidationResult> errors = new List<ValidationResult>();
        if (EstablishedYear > DateTime.Now.Year)
        {
            errors.Add(new ValidationResult("Established year cannot be in the future!", new [] {nameof(EstablishedYear)}));
        }
        return errors;
    }
}