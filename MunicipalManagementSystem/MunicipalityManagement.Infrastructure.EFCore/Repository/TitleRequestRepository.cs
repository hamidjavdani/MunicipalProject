using _0_Framework.Infrastructure;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using MunicipalityManagement.Domain.Title_RequestAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class TitleRequestRepository : RepositoryBase<long, TitleRequest>, ITitleRequestRepository
{
    private MunicipalityContext _context;

    public TitleRequestRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }

    public EditTitleRequest GetDetails(long id)
    {
        return _context.tbltitlerequest.Select(x => new EditTitleRequest()
        {
            Id = x.Id,
            Name = x.Name
        }
          ).FirstOrDefault(x => x.Id == id);
    }

    public List<TitleRequestViewModel> GetTitleRequest()
    {
        return _context.tbltitlerequest.Select(x => new TitleRequestViewModel
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }

    public List<TitleRequestViewModel> Search(TitleRequestSearchModel searchModel)
    {
        var query = _context.tbltitlerequest.Select(x => new TitleRequestViewModel
        {
            Id = x.Id,
            Name = x.Name

        });

        if (!string.IsNullOrWhiteSpace(searchModel.Name))
            query = query.Where(x => x.Name.Contains(searchModel.Name));
        return query.OrderByDescending(x => x.Id).ToList();


    }
}