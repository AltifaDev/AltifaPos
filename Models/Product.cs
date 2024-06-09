namespace AltifaPos.Models
{
    public class Product
    {
        public int  ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? CatagoryID {  get; set; }
        public string? Description { get; set; }
        public decimal Qauntity { get; set; }
        public string? Unit { get; set; }

        public decimal Price { get; set; }
        public string? ImageBase64 { get; set; } // Add ImageBase64 property

        public bool AlreadySale { get; set; }
        public bool WaitingSale { get; set; }
        public bool NotSale { get; set; }
    }

}
