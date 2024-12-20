using _0_Framework.Domain;
using MunicipalityManagement.Domain.ListBoxAgg;
using MunicipalityManagement.Domain.SakhtemanAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.MelkAgg;

public class Melk : EntityBase
{

    public int Cnmantagheh { get; private set; }
    public int Cnhozeh { get; private set; }
    public int Cnblock { get; private set; }
    public int Cnmelk { get; private set; }

    public string Cnmantaghehold { get; private set; }
    public string Cnhozehold { get; private set; }
    public string Cnblockold { get; private set; }
    public string Cnmelkold { get; private set; }


    public decimal Masahatsanad { get; private set; }
    public decimal Masahateslahi { get; private set; }

    public long Idtypesanad { get; private set; }
    public int Idtarakompayeh { get; private set; }
    public long Idkarbaritarhejameh { get; private set; }
    public long Idstatemelk { get; private set; }
    public long Idpahnehtarhejameh { get; private set; }
    public long Idhamjavari { get; private set; }
    public long Idzaribpahneh { get; private set; }
    public long Idkarbaribaft { get; private set; }
    public long Idkarbaripahnehbaft { get; private set; }
    public long Idtarhehtafzili { get; private set; }
    public bool Baftfarsudeh { get; private set; }
    public bool Baftkohan { get; private set; }
    public string Address { get; private set; }

    public string Pelakasli { get; private set; }
    public string Pelakfarei1 { get; private set; }
    public string Pelakfarei2 { get; private set; }

    public string Tozihat { get; private set; }
    public List<Sakhteman> Sakhtemans { get; private set; }

    public ListBox ListBoxtypesanad { get; private set; }
    public ListBox ListBoxkarbaritarhejameh { get; private set; }
    //public ListBox ListBoxstatemelk { get; private set; }
    //public ListBox ListBoxpahnehtarhejameh { get; private set; }

    //public ListBox ListBoxhamjavari { get; private set; }
    //public ListBox ListBoxzaribpahneh { get; private set; }
    //public ListBox ListBoxkarbaribaft { get; private set; }
    //public ListBox ListBoxkarbaripahnehbaft { get; private set; }
    //public ListBox ListBoxtarhehtafzili { get; private set; }


    public Melk(int cnmantagheh, int cnhozeh, int cnblock,
        int cnmelk, string cnmantaghehold, string cnhozehold,
        string cnblockold, string cnmelkold, decimal masahatsanad,
        decimal masahateslahi, long idtypesanad,
        int idtarakompayeh, long idkarbaritarhejameh,
        long idstatemelk, long idpahnehtarhejameh,
        long idhamjavari, long idzaribpahneh, long idkarbaribaft,
        long idkarbaripahnehbaft, long idtarhehtafzili,
        bool baftfarsudeh, bool baftkohan, string address,
        string pelakasli,
        string pelakfarei1,
        string pelakfarei2,
        string tozihat)
    {
        Cnmantagheh = cnmantagheh;
        Cnhozeh = cnhozeh;
        Cnblock = cnblock;
        Cnmelk = cnmelk;
        Cnmantaghehold = cnmantaghehold;
        Cnhozehold = cnhozehold;
        Cnblockold = cnblockold;
        Cnmelkold = cnmelkold;
        Masahatsanad = masahatsanad;
        // Masahateslahi = masahateslahi;
        Idtypesanad = idtypesanad;
        //Idtarakompayeh = idtarakompayeh;
        //Idkarbaritarhejameh = idkarbaritarhejameh;
        //Idstatemelk = idstatemelk;
        //Idpahnehtarhejameh = idpahnehtarhejameh;
        //Idhamjavari = idhamjavari;
        //Idzaribpahneh = idzaribpahneh;
        //Idkarbaribaft = idkarbaribaft;
        //Idkarbaripahnehbaft = idkarbaripahnehbaft;
        //Idtarhehtafzili = idtarhehtafzili;
        this.Baftfarsudeh = baftfarsudeh;
        //this.Baftkohan = baftkohan;
        Address = address;
        this.Pelakasli = pelakasli;
        this.Pelakfarei1 = pelakfarei1;
        this.Pelakfarei2 = pelakfarei2;
        Tozihat = tozihat;
        // ListBoxtypesanad = new ListBox();
    }

    public Melk()
    {
        Sakhtemans = new List<Sakhteman>();

    }

    public Melk(ListBox listBoxtypesanad,
        ListBox listBoxkarbaritarhejameh)
    {
        ListBoxtypesanad = listBoxtypesanad;
        ListBoxkarbaritarhejameh = listBoxkarbaritarhejameh;
    }

    public void Edit(int cnmantagheh, int cnhozeh, int cnblock,
        int cnmelk, string cnmantaghehold, string cnhozehold,
        string cnblockold, string cnmelkold, decimal masahatsanad,
        decimal masahateslahi, long idtypesanad,
        int idtarakompayeh, long idkarbaritarhejameh,
        long idstatemelk, long idpahnehtarhejameh,
        long idhamjavari, long idzaribpahneh, long idkarbaribaft,
        long idkarbaripahnehbaft, long idtarhehtafzili,
        bool baftfarsudeh, bool baftkohan, string address,
        string pelakasli,
        string pelakfarei1,
        string pelakfarei2, string tozihat)
    {
        Cnmantagheh = cnmantagheh;
        Cnhozeh = cnhozeh;
        Cnblock = cnblock;
        Cnmelk = cnmelk;
        Cnmantaghehold = cnmantaghehold;
        Cnhozehold = cnhozehold;
        Cnblockold = cnblockold;
        Cnmelkold = cnmelkold;
        Masahatsanad = masahatsanad;
        Masahateslahi = masahateslahi;
        Idtypesanad = idtypesanad;
        Idtarakompayeh = idtarakompayeh;
        Idkarbaritarhejameh = idkarbaritarhejameh;
        Idstatemelk = idstatemelk;
        Idpahnehtarhejameh = idpahnehtarhejameh;
        Idhamjavari = idhamjavari;
        Idzaribpahneh = idzaribpahneh;
        Idkarbaribaft = idkarbaribaft;
        Idkarbaripahnehbaft = idkarbaripahnehbaft;
        Idtarhehtafzili = idtarhehtafzili;
        this.Baftfarsudeh = baftfarsudeh;
        this.Baftkohan = baftkohan;
        Address = address;
        this.Pelakasli = pelakasli;
        this.Pelakfarei1 = pelakfarei1;
        this.Pelakfarei2 = pelakfarei2;
        Tozihat = tozihat;
    }


    public void EditKarbari(int cnmantagheh, int cnhozeh, int cnblock,
     int cnmelk, string cnmantaghehold, string cnhozehold,
     string cnblockold, string cnmelkold, decimal masahatsanad,
     decimal masahateslahi, long idtypesanad,
     int idtarakompayeh, long idkarbaritarhejameh,
     long idstatemelk, long idpahnehtarhejameh,
     long idhamjavari, long idzaribpahneh, long idkarbaribaft,
     long idkarbaripahnehbaft, long idtarhehtafzili,
     bool baftfarsudeh, bool baftkohan, string address,
     string pelakasli,
     string pelakfarei1,
     string pelakfarei2, string tozihat)
    {

        Idtarakompayeh = idtarakompayeh;
        Idkarbaritarhejameh = idkarbaritarhejameh;
        Idstatemelk = idstatemelk;
        Idpahnehtarhejameh = idpahnehtarhejameh;
        Idhamjavari = idhamjavari;
        Idzaribpahneh = idzaribpahneh;

        Idtarhehtafzili = idtarhehtafzili;


    }

    public void EditKarbaribaft(int cnmantagheh, int cnhozeh, int cnblock,
   int cnmelk, string cnmantaghehold, string cnhozehold,
   string cnblockold, string cnmelkold, decimal masahatsanad,
   decimal masahateslahi, long idtypesanad,
   int idtarakompayeh, long idkarbaritarhejameh,
   long idstatemelk, long idpahnehtarhejameh,
   long idhamjavari, long idzaribpahneh, long idkarbaribaft,
   long idkarbaripahnehbaft, long idtarhehtafzili,
   bool baftfarsudeh, bool baftkohan, string address,
   string pelakasli,
   string pelakfarei1,
   string pelakfarei2, string tozihat)
    {

        Idkarbaribaft = idkarbaribaft;
        Idkarbaripahnehbaft = idkarbaripahnehbaft;


    }


}
