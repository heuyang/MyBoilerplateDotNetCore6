using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyBoilerplateDotNetCore6.Entities.Product
{
    public class ProductEntityMapping : IEntityTypeConfiguration<ProductEntity>
    {

        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductShortName).HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.ProductFullName).HasMaxLength(400).IsUnicode(false);
            builder.Property(x => x.Description).HasMaxLength(4096).IsUnicode(false);
            builder.Property(x => x.StandardUnitPrice).IsRequired(true);
            builder.Property(x => x.StandardUnitCost).IsRequired(true);
            builder.Property(x => x.StandardUnitOfMeasure).HasMaxLength(1024).IsUnicode(false);
        }

    }
}
