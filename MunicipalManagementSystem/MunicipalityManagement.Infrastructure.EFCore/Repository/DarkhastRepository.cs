using _0_Framework.Infrastructure;
using MunicipalityManagement.Application.Contracts.Darkhast;
using MunicipalityManagement.Domain.DarkhastAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class DarkhastRepository : RepositoryBase<long, Darkhast>, IDarkhastRepository
{
    private MunicipalityContext _context;

    public DarkhastRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }


    public List<DarkhastViewModel> GetDarkhast()
    {
        return _context.tbldarkhast.Select(x => new DarkhastViewModel
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }

    public List<DarkhastViewModel> GetDarkhast(long id)
    {
        return _context.tbldarkhast.Select(x => new DarkhastViewModel
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }

    public EditDarkhast GetDetails(long id)
    {
        return _context.tbldarkhast.Select(x => new EditDarkhast()
        {
            Id = x.Id,
            Name = x.Name
        }
        ).FirstOrDefault(x => x.Id == id);

    }


    public List<DarkhastViewModel> Search(DarkhastSearchModel searchModel)
    {
        var query = _context.tbldarkhast.Select(x => new DarkhastViewModel
        {
            Id = x.Id,
            Name = x.Name

        });
        if (!string.IsNullOrWhiteSpace(searchModel.Name))
            query = query.Where(x => x.Name.Contains(searchModel.Name));
        return query.OrderByDescending(x => x.Id).ToList();
    }


}
