namespace AspNetCore.Backend.Api.DbModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Code { get; set; }
        public string HashTag { get; set; }
        public string Technologies { get; set; }
        public decimal Discount { get; set; }
    }
}
