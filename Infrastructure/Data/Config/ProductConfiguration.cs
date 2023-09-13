
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");

            builder.HasKey(x => x.Id);
            
            builder.HasIndex(x => new { x.Id, x.Name, x.Sku, x.UrlCode });
            builder.Property(e => e.Name).HasMaxLength(128);
            builder.Property(e => e.Sku).HasMaxLength(128);
            builder.Property(e => e.UrlCode).HasMaxLength(128);
            builder.Property(e => e.DisplayName).HasMaxLength(128);
            builder.Property(e => e.Description).IsUnicode(true).HasMaxLength(2048);

            builder.Property(e => e.SeoAlias).HasMaxLength(1024);
            builder.Property(e => e.MetaTitle).HasMaxLength(1024);
            builder.Property(e => e.MetaKeyword).HasMaxLength(1024);
            builder.Property(e => e.MetaDescription).HasMaxLength(2048);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.OriginalPrice).IsRequired();


            builder.HasMany(e => e.ProductImages)
                    .WithOne()
                    .HasForeignKey(e => e.ProductId)
                    .IsRequired(false);

            builder.HasMany<Size>()
                    .WithOne(e => e.Product)
                    .HasForeignKey(e => e.ProductId)
                    .IsRequired(false);
        }
    }
}
