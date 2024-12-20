using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.ListBox;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MunicipalityManagement.Application.Contracts.Melk;

public class CreateMelk
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Cnmantagheh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Cnhozeh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Cnblock { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Cnmelk { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnmantaghehold { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnhozehold { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnblockold { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnmelkold { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public decimal Masahatsanad { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public decimal Masahateslahi { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idtypesanad { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int Idtarakompayeh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idkarbaritarhejameh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idstatemelk { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idpahnehtarhejameh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idhamjavari { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idzaribpahneh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idkarbaribaft { get; set; }
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idkarbaripahnehbaft { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long Idtarhehtafzili { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public bool baftfarsudeh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public bool baftkohan { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Address { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]

    public string pelakasli { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string pelakfarei1 { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string pelakfarei2 { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Tozihat { get; set; }

    public List<ListBoxViewModel> ListBoxtypesanad { get; set; }
    public List<ListBoxViewModel> ListBoxkarbaritarhejameh { get; set; }
    public List<ListBoxViewModel> ListBoxstatemelk { get; set; }
    public List<ListBoxViewModel> ListBoxpahnehtarhejameh { get; set; }

    public List<ListBoxViewModel> ListBoxhamjavari { get; set; }
    public List<ListBoxViewModel> ListBoxzaribpahneh { get; set; }
    public List<ListBoxViewModel> ListBoxkarbaribaft { get; set; }
    public List<ListBoxViewModel> ListBoxkarbaripahnehbaft { get; set; }
    public List<ListBoxViewModel> ListBoxtarhehtafzili { get; set; }

    //  public List<ListBoxViewModel> ListBoxzaribpahneh { get; set; }



}
