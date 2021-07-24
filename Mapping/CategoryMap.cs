using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VarejaoDoNene.Models;

namespace VarejaoDoNene.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryName);
            builder.Property(c => c.CategoryName).HasMaxLength(20).IsRequired();

            builder.HasMany(p => p.Products).WithOne(c => c.Category);

            builder.ToTable("Categories");
        }
    }
}