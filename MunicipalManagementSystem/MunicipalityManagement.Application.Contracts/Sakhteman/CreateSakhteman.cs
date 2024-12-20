using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.ListBox;
using MunicipalityManagement.Application.Contracts.ListKarbari;
using MunicipalityManagement.Application.Contracts.ListTabaghat;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagement.Application.Contracts.Sakhteman;

public class CreateSakhteman
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Idsakhteman { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idtabagheh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idkarbari { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idestefadeh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Ideskelet { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idmarhalesakhtemani { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idnama { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Salsakht { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Idvahed { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]

    public int Tedadvahed { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public decimal Masahat { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public decimal Pishamadegi { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public decimal Ertefah { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public decimal Masahahttariz { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idmelk { get; set; }

    public List<ListTabaghatViewModel> ListBoxtabagheh { get; set; }
    public List<ListKarbariViewModel> ListBoxkarbari { get; set; }
    public List<ListBoxViewModel> ListBoxestefadeh { get; set; }
    public List<ListBoxViewModel> ListBoxeskelet { get; set; }
    public List<ListBoxViewModel> ListBoxmarhalesakhtemani { get; set; }
    public List<ListBoxViewModel> ListBoxnama { get; set; }
}
