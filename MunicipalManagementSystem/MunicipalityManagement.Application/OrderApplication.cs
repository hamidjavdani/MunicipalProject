using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.Order;
using MunicipalityManagement.Domain.OrderAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class OrderApplication : IOrderApplication
{
    private readonly IOrderRepository _OrderRepository;

    public OrderApplication(IOrderRepository orderRepository)
    {
        _OrderRepository = orderRepository;
    }

    public OperationResult Create(PlaceOrder command)
    {
        var operation = new OperationResult();
        //if (_OrderRepository.Exists(x => x.Name == command.Name))
        //    return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var order = new Order(command.AccountId, command.RequestType,
            command.Cnmantagheh, command.Cnhozeh, command.Cnblock, command.Cnmelk, command.IssueTrackingNo);
        _OrderRepository.Create(order);
        _OrderRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditOrder command)
    {
        var operation = new OperationResult();
        var order = _OrderRepository.Get(command.Id);
        if (order == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        //if (_OrderRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
        //    return operation.Failed(ApplicationMessages.DuplicatedRecord);
        order.Edit(command.AccountId, command.RequestType,
            command.Cnmantagheh, command.Cnhozeh, command.Cnblock, command.Cnmelk, command.IssueTrackingNo);
        _OrderRepository.SaveChange();
        return operation.Succedded();
    }

    public EditOrder GetDetails(long id)
    {
        return _OrderRepository.GetDetails(id);
    }

    public List<OrderViewModel> Search(OrderSearchModel searchModel)
    {
        return _OrderRepository.Search(searchModel);
    }
}
