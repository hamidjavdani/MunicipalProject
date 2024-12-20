using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.Order;
using System.Collections.Generic;
namespace MunicipalityManagement.Domain.OrderAgg;

public interface IOrderRepository : IRepository<long, Order>
{
    EditOrder GetDetails(long id);
    //List<OrderViewModel> GetDarkhast(long id);
    List<OrderViewModel> Search(OrderSearchModel searchModel);
}
