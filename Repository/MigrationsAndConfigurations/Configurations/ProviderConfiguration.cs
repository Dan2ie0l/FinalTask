using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorApp.Repository.Models;
namespace Repository.Migrations
{
    class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("Providers");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(o => o.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(o => o.Type).HasColumnName("Type").HasMaxLength(50).IsRequired();
            builder.Property(o => o.GroupId).HasColumnName("GroupId").IsRequired();
            builder.Property(o => o.Active).HasColumnName("Active").IsRequired();
            builder.Property(o => o.CreatedOn).HasColumnName("CreatedOn").IsRequired();
            builder.Property(o => o.ModifiedOn).HasColumnName("ModifiedOn").IsRequired();

        }
    }
}
