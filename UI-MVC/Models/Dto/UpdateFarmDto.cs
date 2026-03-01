using System.ComponentModel.DataAnnotations;

namespace FarmManagement.UI.Web.Models.Dto;

public class UpdateFarmDto
{
    [Range(0.01, 10000)]
    public double? SizeInHectares { get; set; }
}