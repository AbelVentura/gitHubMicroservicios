﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public partial class OfferStatus
    {
        public OfferStatus()
        {
            Offers = new HashSet<Offer>();
        }

        public int OfferStatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}