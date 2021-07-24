using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VarejaoDoNene.Models;

namespace VarejaoDoNene.Mapping
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(c => c.CPF);
            builder.Property(n => n.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();

            builder.HasOne(r => r.Role).WithMany(a => a.Accounts).HasForeignKey(a => a.RoleName).IsRequired();
            builder.HasMany(s => s.Sale).WithOne(a => a.Account).HasForeignKey(s => s.SaleId). IsRequired();


        }
    }
}