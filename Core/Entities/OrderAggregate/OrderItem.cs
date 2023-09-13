namespace Core.Entities
{
    public class OrderItem : BaseEntity
    {
        public OrderItem()
        {
        }

        public OrderItem(Guid productItemId, string productName, string pictureUrl, string sku , double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            ProductItemId = productItemId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Sku = sku;
        }
        public Guid ProductItemId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}