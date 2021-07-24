using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VarejaoDoNene.Models;

namespace VarejaoDoNene.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.SaleId);
            builder.Property(d => d.DateSale).HasMaxLength(10).IsRequired();
            builder.Property(a => a.Amount).IsRequired();

            builder.HasOne(a => a.Account).WithMany(s => s.Sale).HasForeignKey(c => c.CPF).IsRequired();
            builder.HasMany(i => i.ItemSale).WithOne(s => s.Sale).HasForeignKey(i => i.ItemSaleId). IsRequired();
            

            builder.ToTable("Sales");

        }
    }
}