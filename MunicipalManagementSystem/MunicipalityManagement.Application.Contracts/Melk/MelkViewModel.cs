namespace MunicipalityManagement.Application.Contracts.Melk;

public class MelkViewModel
{
    public string Codenosazi { get; set; }
    public long Id { get; set; }
    public int Cnmantagheh { get; set; }
    public int Cnhozeh { get; set; }
    public int Cnblock { get; set; }
    public int Cnmelk { get; set; }

    public string Cnmantaghehold { get; set; }
    public string Cnhozehold { get; set; }
    public string Cnblockold { get; set; }
    public string Cnmelkold { get; set; }

    public string Address { get; set; }

    public string karbaritarhjameh { get; set; }

    public long Idkarbaritarhehjameh { get; set; }
    public decimal Masahatsanad { get; set; }
    public decimal Masahateslahi { get; set; }

    public string namekarbaritarhjameh { get; set; }
    public string nametypesanad { get; set; }
}
