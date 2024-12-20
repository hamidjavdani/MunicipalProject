using _0_Framework.Application;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagement.Application.Contracts.Darkhast;

public class CreateDarkhast
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Name { get; set; }

}
