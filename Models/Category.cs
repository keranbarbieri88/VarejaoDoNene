using System.Collections.Generic;


namespace VarejaoDoNene.Models
{
    public class Category
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}