﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microservice.Demo.Report.API.Data.Contexts;
using Microservice.Demo.Report.API.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Microservice.Demo.Report.API.Data.Contexts.Configurations
{
    public partial class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> entity)
        {
            entity.ToTable("Message");

            entity.Property(e => e.Type)
                .HasMaxLength(500)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Message> entity);
    }
}
