using System.Collections.Generic;

namespace VarejaoDoNene.Models
{
    public class Product
    {
        public int ProductId { get; set; }       
        public string ProductName { get; set; }   
        public int Quantity { get; set; }      
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }

        public int ItemSaleId { get; set; } 
        public ICollection<ItemSale> ItemSale { get; set; }
    }
}