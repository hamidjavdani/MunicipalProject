using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MunicipalityManagement.Application.Contracts.Request;
using MunicipalityManagement.Domain.RequestAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;


public class RequestRepository : RepositoryBase<long, Request>, IRequestRepository
{
    private MunicipalityContext _context;

    public RequestRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }

    public EditRequest GetDetails(long id)
    {
        return _context.tblrequest.Select(x => new EditRequest()
        {
            Id = x.Id

        }
      ).FirstOrDefault(x => x.Id == id);
    }

    public List<RequestViewModel> Search(RequestSearchModel searchModel)
    {
        var query = _context.tblrequest.Include(x => x.TitleRequests
     ).Select(x => new RequestViewModel
     {
         AccountId = x.AccountId,
         Codemelk = x.Codemelk,
         Name = x.Codemelk,
         Codenosazi = x.Cnmantagheh.ToString() + "-" + x.Cnhozeh.ToString() + "-" + x.Cnblock.ToString() + "-" + x.Cnmelk.ToString(),
         Onvandarkhast = x.TitleRequests.Name

     });
        if (!string.IsNullOrWhiteSpace(searchModel.Codemelk))
            query = query.Where(x => x.Codemelk.Contains(searchModel.Codemelk));
        return query.OrderByDescending(x => x.AccountId).ToList();
    }
}

