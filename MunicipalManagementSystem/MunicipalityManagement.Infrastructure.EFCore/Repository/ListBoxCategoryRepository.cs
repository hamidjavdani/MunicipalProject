using _0_Framework.Infrastructure;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using MunicipalityManagement.Domain.ListBoxCategoryAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class ListBoxCategoryRepository : RepositoryBase<long, ListBoxCategory>, IListBoxCategoryRepository
{

    private MunicipalityContext _context;

    public ListBoxCategoryRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }


    public List<ListBoxCategoryViewModel> GetListBoxCategories()
    {
        return _context.tbllistboxcategory.Select(x => new ListBoxCategoryViewModel
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }


    public EditListBoxCategory GetDetails(long id)
    {
        return _context.tbllistboxcategory.Select(x => new EditListBoxCategory()
        {
            Id = x.Id,
            Name = x.Name
        }
        ).FirstOrDefault(x => x.Id == id);

    }


    public List<ListBoxCategoryViewModel> Search(ListBoxCategorySearchModel searchModel)
    {
        var query = _context.tbllistboxcategory.Select(x => new ListBoxCategoryViewModel
        {
            Id = x.Id,
            Name = x.Name

        });
        if (!string.IsNullOrWhiteSpace(searchModel.Name))
            query = query.Where(x => x.Name.Contains(searchModel.Name));
        return query.OrderByDescending(x => x.Id).ToList();
    }
}
