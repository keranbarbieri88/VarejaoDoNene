using System.Collections.Generic;

namespace VarejaoDoNene.Models
{
    public class ItemSale
    {
        public int ItemSaleId { get; set; }        
        public int Quantity { get; set; }    

        public int ProductId { get; set; }        
        public Product Product { get; set; }   
         
        public int SaleId { get; set; }
        public Sale Sale{ get; set; }
    }
}