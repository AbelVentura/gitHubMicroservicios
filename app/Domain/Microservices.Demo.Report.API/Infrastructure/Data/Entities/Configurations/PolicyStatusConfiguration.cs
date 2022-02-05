﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microservices.Demo.Report.API.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microservices.Demo.Report.API.Data.Entities.Configurations
{
    public partial class PolicyStatusConfiguration : IEntityTypeConfiguration<PolicyStatus>
    {
        public void Configure(EntityTypeBuilder<PolicyStatus> entity)
        {
            entity.ToTable("PolicyStatus");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PolicyStatus> entity);
    }
}