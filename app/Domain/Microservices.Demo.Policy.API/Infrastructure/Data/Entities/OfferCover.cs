// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservices.Demo.Policy.API.Infrastructure.Data.Entities
{
    public partial class OfferCover
    {
        public int OfferCoverId { get; set; }
        public int OfferId { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

        public virtual Offer Offer { get; set; }
    }
}