using System;
using System.Collections.Generic;
using Core.Entities;

namespace Core.DTO.ResponseDto;

public class OrderResponseDto
{
    public Guid Id { get; set; }
    public string BuyerName { get; set; }
    public string BuyerEmail { get; set; }
    public IReadOnlyList<OrderItem> OrderItems { get; set; }
    public string BuyerPhoneNumber { get; set; }
    public string BuyerAddress { get; set; }

}
