using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MunicipalityManagement.Application.Contracts.Melk;
using MunicipalityManagement.Domain.MelkAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class MelkRepository : RepositoryBase<long, Melk>, IMelkRepository
{
    private MunicipalityContext _context;

    public MelkRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }


    public EditMelk GetDetails(long id)
    {
        return _context.tblmelk.Select(x => new EditMelk()
        {
            Id = x.Id,

            Address = x.Address,
            Tozihat = x.Tozihat,

            Cnmantagheh = x.Cnmantagheh,
            Cnhozeh = x.Cnhozeh,
            Cnblock = x.Cnblock,
            Cnmelk = x.Cnmelk,

            Cnmantaghehold = x.Cnmantaghehold,
            Cnhozehold = x.Cnhozehold,
            Cnblockold = x.Cnblockold,
            Cnmelkold = x.Cnmelkold,

            Idtarakompayeh = x.Idtarakompayeh,


            Idtypesanad = x.Idtypesanad,

            Idkarbaritarhejameh = x.Idkarbaritarhejameh,
            Idpahnehtarhejameh = x.Idpahnehtarhejameh,
            Idzaribpahneh = x.Idzaribpahneh,
            Idhamjavari = x.Idhamjavari,

            Idstatemelk = x.Idstatemelk,

            Idkarbaribaft = x.Idkarbaribaft,
            Idkarbaripahnehbaft = x.Idkarbaripahnehbaft,

            Idtarhehtafzili = x.Idtarhehtafzili,
            Masahatsanad = x.Masahatsanad,
            Masahateslahi = x.Masahateslahi,
            pelakasli = x.Pelakasli,
            pelakfarei1 = x.Pelakfarei1,
            pelakfarei2 = x.Pelakfarei2


        }
        ).FirstOrDefault(x => x.Id == id);

    }


    public List<MelkViewModel> Search(MelkSearchModel searchModel)
    {
        var query = _context.tblmelk.Include(x => x.ListBoxkarbaritarhejameh
            ).Select(x => new MelkViewModel
            {
                Id = x.Id,
                Cnmantagheh = x.Cnmantagheh,
                Codenosazi = x.Cnmantagheh.ToString() + "-" + x.Cnhozeh.ToString() + "-" + x.Cnblock.ToString() + "-" + x.Cnmelk.ToString(),
                Address = x.Address,
                Masahatsanad = x.Masahatsanad,
                Masahateslahi = x.Masahateslahi,

                namekarbaritarhjameh = x.ListBoxkarbaritarhejameh.Name,
                nametypesanad = x.ListBoxtypesanad.Name

            });
        //if (!string.IsNullOrWhiteSpace(searchModel.Cnmantaghehold))
        //    query = query.Where(x => x.Cnmantaghehold.Contains(searchModel.Cnmantaghehold));
        return query.OrderByDescending(x => x.Id).ToList();

    }
}
