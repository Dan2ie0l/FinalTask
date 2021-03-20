using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Migrations
{
    class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            
            builder.ToTable("Groups");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(o => o.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(o => o.Type).HasColumnName("Type").HasMaxLength(50).IsRequired();
            builder.Property(o => o.Active).HasColumnName("Active").IsRequired();
            builder.Property(o => o.CreatedOn).HasColumnName("CreatedOn").IsRequired();
            builder.Property(o => o.ModifiedOn).HasColumnName("ModifedOn").IsRequired();

            builder.Metadata.FindNavigation(nameof(Group.providers)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(o => o.providers).WithOne(b => b.Group).HasForeignKey(b => b.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
