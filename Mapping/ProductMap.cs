using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VarejaoDoNene.Models;

namespace VarejaoDoNene.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(pn => pn.ProductName).HasMaxLength(30).IsRequired();
            builder.Property(q => q.Quantity).IsRequired();
            builder.Property(pr => pr.Price).IsRequired();
            

            builder.HasOne(c => c.Category).WithMany(p => p.Products).HasForeignKey(c => c.CategoryName).IsRequired();
            builder.HasMany(i => i.ItemSale).WithOne(p => p.Product).HasForeignKey(i => i.ItemSaleId).IsRequired();
           
          
          
        

            builder.ToTable("Products");

        }
    }
}