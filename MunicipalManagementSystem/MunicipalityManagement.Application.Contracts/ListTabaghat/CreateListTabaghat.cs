using _0_Framework.Application;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagement.Application.Contracts.ListTabaghat;

public class CreateListTabaghat
{

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Name { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Idtabagheh { get; set; }
}
