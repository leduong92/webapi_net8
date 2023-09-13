

using Core.DTO.RequestDto;
using Core.DTO.ResponseDto;
using Core.Entities;
using Core.Interfaces;
using Core.Model;
using Infrastructure.HelperService;
using Newtonsoft.Json;

namespace Infrastructure.Services;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _uow;
    public OrderService(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<OrderResponseDto> CreateOrder(OrderRequestDto request)
    {
        var items = new List<OrderItem>();

        foreach (var item in request.OrderItems.Items)
        {
            var orderItem = new OrderItem(item.Id, item.Name, null, item.Sku, item.Price, item.Quantity);
            items.Add(orderItem);
        }

        var order = new Order(items, request.BuyerName, request.BuyerEmail, request.BuyerPhoneNumber, request.BuyerAddress);
        _uow.Repository<Order>().Insert(order);

        var result = await _uow.Complete();

        if (result <= 0) return null;

        var rsp = new OrderResponseDto() {
            Id = order.Id,
            BuyerName = order.BuyerName,
            BuyerEmail = order.BuyerEmail,
            BuyerPhoneNumber = order.BuyerPhoneNumber,
            BuyerAddress = order.BuyerAddress
        };
        
        return rsp;
    }
}
