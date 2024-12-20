using _0_Framework.Domain;
using MunicipalityManagement.Domain.ListKarbariAgg;
using MunicipalityManagement.Domain.ListTabaghatAgg;
using MunicipalityManagement.Domain.MelkAgg;
namespace MunicipalityManagement.Domain.SakhtemanAgg;

public class Sakhteman : EntityBase
{
    public int Idsakhteman { get; private set; }
    public long Idtabagheh { get; private set; }
    public ListTabaghat Tabagaht { get; private set; }
    public long Idkarbari { get; private set; }
    public ListKarbari Karbari { get; private set; }
    public long Idestefadeh { get; private set; }
    public long Ideskelet { get; private set; }
    public long Idmarhalesakhtemani { get; private set; }
    public long Idnama { get; private set; }
    public int Salsakht { get; private set; }
    public int Idvahed { get; private set; }
    public int Tedadvahed { get; private set; }
    public decimal Masahat { get; private set; }
    public decimal Pishamadegi { get; private set; }
    public decimal Ertefah { get; private set; }
    public decimal Masahahttariz { get; private set; }
    public long Idmelk { get; private set; }
    public Melk Melk { get; private set; }
    //     public ListBox ListBoxtabaghat { get; private set; }
    //public ListBox ListBoxkarbari { get; private set; }
    //public ListBox ListBoxestefadeh { get; private set; }
    //public Sakhteman(ListBox listBoxtabaghat)
    //{
    //    ListBoxtabaghat = listBoxtabaghat;
    //}
    public Sakhteman(ListTabaghat listabaghat, ListKarbari listKarbari)
    {
        Tabagaht = listabaghat;
        Karbari = listKarbari;
    }
    public Sakhteman(int idsakhteman,
        long idtabagheh,
        long idkarbari,
        long idestefadeh,
        long ideskelet,
        long idmarhalesakhtemani,
        long idnama,
        int salsakht,
        int idvahed,
        int tedadvahed,
        decimal masahat,
        decimal pishamadegi,
        decimal ertefah,
        decimal masahahttariz,
        long idmelk)
    {
        Idsakhteman = idsakhteman;
        Idtabagheh = idtabagheh;
        Idkarbari = idkarbari;
        Idestefadeh = idestefadeh;
        Ideskelet = ideskelet;
        Idmarhalesakhtemani = idmarhalesakhtemani;
        Idnama = idnama;
        Salsakht = salsakht;
        Idvahed = idvahed;
        Tedadvahed = tedadvahed;
        Masahat = masahat;
        Pishamadegi = pishamadegi;
        Ertefah = ertefah;
        Masahahttariz = masahahttariz;
        Idmelk = idmelk;
    }


    public void Edit(int idsakhteman,
           long idtabagheh,
           long idkarbari,
           long idestefadeh,
           long ideskelet,
           long idmarhalesakhtemani,
           long idnama,
           int salsakht,
           int idvahed,
           int tedadvahed,
           decimal masahat,
           decimal pishamadegi,
           decimal ertefah,
           decimal masahahttariz,
           long idmelk)
    {
        Idsakhteman = idsakhteman;
        Idtabagheh = idtabagheh;
        Idkarbari = idkarbari;
        Idestefadeh = idestefadeh;
        Ideskelet = ideskelet;
        Idmarhalesakhtemani = idmarhalesakhtemani;
        Idnama = idnama;
        Salsakht = salsakht;
        Idvahed = idvahed;
        Tedadvahed = tedadvahed;
        Masahat = masahat;
        Pishamadegi = pishamadegi;
        Ertefah = ertefah;
        Masahahttariz = masahahttariz;
        Idmelk = idmelk;
    }



}
