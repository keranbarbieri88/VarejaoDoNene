using System.Collections.Generic;

namespace VarejaoDoNene.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
         public string DateSale { get; set; }

        public string CPF { get; set; }  
        public Account Account { get; set; }  
              
        public double Amount { get; set; }
        public int ItemSaleId { get; set; }  
        public ICollection<ItemSale> ItemSale { get; set; }

    }
}