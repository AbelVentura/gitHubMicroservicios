﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microservices.Demo.Report.API.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microservices.Demo.Report.API.Data.Entities.Configurations
{
    public partial class PolicyHolderConfiguration : IEntityTypeConfiguration<PolicyHolder>
    {
        public void Configure(EntityTypeBuilder<PolicyHolder> entity)
        {
            entity.ToTable("PolicyHolder");

            entity.Property(e => e.FirstName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Pesel)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Address)
                .WithMany(p => p.PolicyHolders)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PolicyHolderAddress");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PolicyHolder> entity);
    }
}