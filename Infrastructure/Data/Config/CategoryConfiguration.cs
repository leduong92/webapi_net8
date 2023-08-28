
using Core.Entities;
using Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("categories");

            builder.HasKey(e => e.Id);
            builder.HasIndex(x => x.SortOrder);

            builder.Property(e => e.Status).HasDefaultValue(Status.Active);
            builder.Property(e => e.Name).IsRequired().IsUnicode(true).HasMaxLength(256);
            builder.Property(e => e.DisplayName).IsUnicode(true).HasMaxLength(256);
            builder.Property(e => e.UrlCode).IsRequired(true).HasMaxLength(128);
            builder.Property(e => e.SeoAlias).IsUnicode(true).HasMaxLength(256);
            builder.Property(e => e.MetaTitle).IsUnicode(true).HasMaxLength(2048);
            builder.Property(e => e.MetaKeyword).IsUnicode(true).HasMaxLength(2048);
            builder.Property(e => e.MetaDescription).IsUnicode(true).HasMaxLength(2048);
            builder.Property(e => e.ImageUrl).IsUnicode(true).HasMaxLength(2048);

            builder.HasMany<Product>()
                    .WithOne(e => e.Category)
                    .HasForeignKey(e => e.CategoryId)
                    .IsRequired();
        }
    }
}
