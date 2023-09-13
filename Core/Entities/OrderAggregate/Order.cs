using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
        }

        public Order(IReadOnlyList<OrderItem> orderItems,string buyerName, string buyerEmail, string buyerPhoneNumber, string buyerAddress)
        {
            BuyerName = buyerName;
            BuyerEmail = buyerEmail;
            OrderItems = orderItems;
            BuyerPhoneNumber = buyerPhoneNumber;
            BuyerAddress = buyerAddress;
        }
        public string BuyerName { get; set; }
        public string BuyerEmail { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public string BuyerAddress { get; set; }

    }
}