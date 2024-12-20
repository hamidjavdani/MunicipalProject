using _0_Framework.Infrastructure;
using MunicipalityManagement.Application.Contracts.ListTabaghat;
using MunicipalityManagement.Domain.ListTabaghatAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class ListTabaghatRepository : RepositoryBase<long, ListTabaghat>, IListTabaghatRepository
{
    private MunicipalityContext _context;

    public ListTabaghatRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }

    public List<ListTabaghatViewModel> GetListTabaghat(long id)
    {
        return _context.tbltabaghat.Select(x => new ListTabaghatViewModel
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }

    public EditListTabaghat GetDetails(long id)
    {
        return _context.tbltabaghat.Select(x => new EditListTabaghat()
        {
            Id = x.Id,
            Name = x.Name,
            Idtabagheh = x.Idtabagheh
        }
        ).FirstOrDefault(x => x.Id == id);

    }

    public List<ListTabaghatViewModel> Search(ListTabaghatSearchModel searchModel)
    {
        var query = _context.tbltabaghat.Select(x => new ListTabaghatViewModel
        {
            Id = x.Id,
            Name = x.Name

        });
        if (!string.IsNullOrWhiteSpace(searchModel.Name))
            query = query.Where(x => x.Name.Contains(searchModel.Name));
        return query.OrderByDescending(x => x.Id).ToList();
    }


}
