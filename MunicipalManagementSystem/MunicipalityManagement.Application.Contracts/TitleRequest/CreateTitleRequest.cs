using _0_Framework.Application;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagement.Application.Contracts.TitleRequest;

public class CreateTitleRequest
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Name { get; set; }
}
