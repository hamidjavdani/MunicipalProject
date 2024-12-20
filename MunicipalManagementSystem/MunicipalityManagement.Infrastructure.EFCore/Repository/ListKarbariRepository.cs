using _0_Framework.Infrastructure;
using MunicipalityManagement.Application.Contracts.ListKarbari;
using MunicipalityManagement.Domain.ListKarbariAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class ListKarbariRepository : RepositoryBase<long, ListKarbari>, IListKarbariRepository
{
    private MunicipalityContext _context;

    public ListKarbariRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }
    public EditListKarbari GetDetails(long id)
    {
        return _context.tblkarbari.Select(x => new EditListKarbari()
        {
            Id = x.Id,
            Name = x.Name,
            Idkarbari = x.Idkarbari
        }
       ).FirstOrDefault(x => x.Id == id);
    }

    public List<ListKarbariViewModel> GetListKarbari(long id)
    {
        return _context.tblkarbari.Select(x => new ListKarbariViewModel
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }

    public List<ListKarbariViewModel> Search(ListKarbariSearchModel searchModel)
    {
        var query = _context.tblkarbari.Select(x => new ListKarbariViewModel
        {
            Id = x.Id,
            Name = x.Name

        });
        if (!string.IsNullOrWhiteSpace(searchModel.Name))
            query = query.Where(x => x.Name.Contains(searchModel.Name));
        return query.OrderByDescending(x => x.Id).ToList();
    }
}
