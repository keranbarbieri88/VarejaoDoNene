using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VarejaoDoNene.Models;


namespace VarejaoDoNene.Mapping
{
    public class ItemSaleMap : IEntityTypeConfiguration<ItemSale>
    {
        public void Configure(EntityTypeBuilder<ItemSale> builder)
        {
            builder.HasKey(i => i.ItemSaleId);
            builder.Property(q => q.Quantity).IsRequired();

           
            builder.HasOne(p => p.Product).WithMany(i => i.ItemSale).HasForeignKey(p => p.ProductId). IsRequired();
            builder.HasOne(s => s.Sale).WithMany(i => i.ItemSale).HasForeignKey(s => s.SaleId). IsRequired();
            
 
            builder.ToTable("ItemSales");
             
        }
    }
}