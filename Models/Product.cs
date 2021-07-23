namespace VarejaoDoNene.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public Category Category { get; set; } 
        public string ProductName { get; set; }
        public Measure Measure { get; set;}

    }
}