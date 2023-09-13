
using Core.DTO.RequestDto;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class OrderController : BaseApiController
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] OrderRequestDto request)
    {
        if (string.IsNullOrEmpty(request.BuyerPhoneNumber))
            return BadRequest($"Phone number is not found");
            
        var results = await _orderService.CreateOrder(request);
        if (results == null)
            return BadRequest($"Cannot create order");
        return Ok(results);
    }
  
}
