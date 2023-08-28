
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class SlideConfiguration : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable("slides");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.SortOrder);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Url).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Image).HasMaxLength(200).IsRequired();
        }
    }
}