namespace W26Week13DatabaseWithAspDotNet.Models
{
    public class Product
    {
        // scalar properties
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public int? CategoryId { get; set; }

        // navigation property
        public Category? Category { get; set; }
    }
}
