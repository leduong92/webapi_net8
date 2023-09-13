using System;
using System.Collections.Generic;
using Core.DTO.BaseDto;
using Core.Entities;

namespace Core.DTO.RequestDto;

public class OrderRequestDto
{
    public string BuyerName { get; set; }
    public string BuyerEmail { get; set; }
    public OrderItemRequest OrderItems { get; set; }
    public string BuyerPhoneNumber { get; set; }
    public string BuyerAddress { get; set; }

}

public class OrderItemRequest
{    
    public List<OrderItemtDto> Items { get; set; }

}



