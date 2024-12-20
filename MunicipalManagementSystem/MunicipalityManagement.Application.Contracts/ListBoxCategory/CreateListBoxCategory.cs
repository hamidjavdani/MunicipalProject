using _0_Framework.Application;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagement.Application.Contracts.ListBoxCategory;

public class CreateListBoxCategory
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Name { get; set; }
}
