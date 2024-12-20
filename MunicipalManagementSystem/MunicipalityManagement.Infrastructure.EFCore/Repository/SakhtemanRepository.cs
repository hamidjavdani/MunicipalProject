using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MunicipalityManagement.Application.Contracts.Sakhteman;
using MunicipalityManagement.Domain.SakhtemanAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class SakhtemanRepository : RepositoryBase<long, Sakhteman>, ISakhtemanRepository
{
    private MunicipalityContext _context;

    public SakhtemanRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }

    public EditSakhteman GetDetails(long id)
    {
        return _context.tblsakteman.Select(x => new EditSakhteman()
        {
            Id = x.Id,
            Idsakhteman = x.Idsakhteman,
            Idnama = x.Idnama,
            Idtabagheh = x.Idtabagheh,
            Idkarbari = x.Idkarbari,
            Idestefadeh = x.Idestefadeh,
            Ideskelet = x.Ideskelet,
            Salsakht = x.Salsakht,
            Tedadvahed = x.Tedadvahed,
            Idvahed = x.Idvahed,
            Masahat = x.Masahat,
            Idmarhalesakhtemani = x.Idmarhalesakhtemani


        }
        ).FirstOrDefault(x => x.Id == id);
    }

    public List<SakhtemanViewModel> Search(long Idmelk)
    {
        //var query = _context.tblsakteman.Include(x => x.ListBoxtabaghat).Select(x => new SakhtemanViewModel
        //{
        var query = _context.tblsakteman.Include(x => x.Tabagaht
           ).Select(x => new SakhtemanViewModel
           {


               Id = x.Id,
               Idsakhteman = x.Idsakhteman,
               Idnama = x.Idnama,
               Idtabagheh = x.Tabagaht.Id,
               Idkarbari = x.Karbari.Id,
               Idestefadeh = x.Idestefadeh,
               Ideskelet = x.Ideskelet,
               Salsakht = x.Salsakht,
               Tedadvahed = x.Tedadvahed,
               Idvahed = x.Idvahed,
               Masahat = x.Masahat,
               Idmarhalesakhtemani = x.Idmarhalesakhtemani,
               Idmelk = x.Idmelk,
               Nametabagheh = x.Tabagaht.Name,
               Namekarbari = x.Karbari.Name


           });
        //  if (!string.IsNullOrWhiteSpace(searchModel.Idsakhteman))
        query = query.Where(x => x.Idmelk == Idmelk);
        return query.OrderByDescending(x => x.Id).ToList();

    }
}
