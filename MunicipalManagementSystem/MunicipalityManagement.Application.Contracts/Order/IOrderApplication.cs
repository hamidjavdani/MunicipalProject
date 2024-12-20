using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.Order;

public interface IOrderApplication
{
    OperationResult Create(PlaceOrder command);
    OperationResult Edit(EditOrder command);
    EditOrder GetDetails(long id);
    List<OrderViewModel> Search(OrderSearchModel searchModel);
}
