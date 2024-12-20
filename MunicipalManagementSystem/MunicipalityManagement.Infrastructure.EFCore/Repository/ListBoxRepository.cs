using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MunicipalityManagement.Application.Contracts.ListBox;
using MunicipalityManagement.Domain.ListBoxAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class ListBoxRepository : RepositoryBase<long, ListBox>, IListBoxRepository
{
    private MunicipalityContext _context;

    public ListBoxRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }

    public EditListBox GetDetails(long id)
    {
        return _context.tbllistbox.Select(x => new EditListBox()
        {
            Id = x.Id,
            Name = x.Name
        }
        ).FirstOrDefault(x => x.Id == id);
    }

    public List<ListBoxViewModel> GetListBoxs(long CategoryId)
    {
        var query = _context.tbllistbox.Include(x => x.Category)
            .Select(x => new ListBoxViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CategoryName = x.Category.Name,
                CategoryId = x.CategoryId,
                CreationDate = x.CreationDate.ToFarsi()

            });

        if (CategoryId != 0)
            query = query.Where(x => x.CategoryId == CategoryId);

        return query.OrderByDescending(x => x.Id).ToList();
    }

    public List<ListBoxViewModel> Search(ListBoxSearchModel searchModel)
    {
        var query = _context.tbllistbox.Include(x => x.Category)
            .Select(x => new ListBoxViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CategoryName = x.Category.Name,
                CategoryId = x.CategoryId,
                CreationDate = x.CreationDate.ToFarsi()

            });
        if (!string.IsNullOrWhiteSpace(searchModel.Name))
            query = query.Where(x => x.Name.Contains(searchModel.Name));


        if (searchModel.CategoryId != 0)
            query = query.Where(x => x.CategoryId == searchModel.CategoryId);

        return query.OrderByDescending(x => x.Id).ToList();


    }


}

