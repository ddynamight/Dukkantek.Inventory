using Dukkantek.Inventory.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dukkantek.Inventory.Persistence.Categories.Configurations
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(p => p.Id);
            builder.Ignore(p => p.DomainEvents);

            builder.Property(p => p.RowVersion)
                .IsRowVersion();
        }
    }
}
