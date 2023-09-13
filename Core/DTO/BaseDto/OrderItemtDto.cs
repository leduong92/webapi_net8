using System;
using System.Collections.Generic;
using Core.Entities;

namespace Core.DTO.BaseDto;

public class OrderItemtDto
{
    public Guid Id { get; set; }
    public string Sku { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

}
