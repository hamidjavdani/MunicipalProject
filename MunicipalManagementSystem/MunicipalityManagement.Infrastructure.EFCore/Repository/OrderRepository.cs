using _0_Framework.Infrastructure;
using MunicipalityManagement.Application.Contracts.Order;
using MunicipalityManagement.Domain.OrderAgg;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class OrderRepository : RepositoryBase<long, Order>, IOrderRepository
{
    private MunicipalityContext _context;

    public OrderRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }

    public EditOrder GetDetails(long id)
    {
        return _context.tbldarkhast.Select(x => new EditOrder()
        {
            Id = x.Id
            //,
            //.//  Name = x.Name
        }
       ).FirstOrDefault(x => x.Id == id);
    }

    public List<OrderViewModel> Search(OrderSearchModel searchModel)
    {
        throw new NotImplementedException();
    }




    //public List<OrderViewModel> Search(OrderSearchModel searchModel)
    //{
    //    var query = _context.tbldarkhast.Select(x => new OrderViewModel
    //    {
    //        Id = x.Id,
    //        Name = x.Name

    //    });
    //    if (!string.IsNullOrWhiteSpace(searchModel.Name))
    //        query = query.Where(x => x.Name.Contains(searchModel.Name));
    //    return query.OrderByDescending(x => x.Id).ToList();
    //}



}
