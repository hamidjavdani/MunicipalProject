using _0_Framework.Application;
using System.ComponentModel.DataAnnotations;
namespace MunicipalityManagement.Application.Contracts.ListKarbari;

public class CreateListKarbari
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Name { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Idkarbari { get; set; }
}
