﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Microservice.Demo.Report.API.Data.Entities
{
    public partial class PolicyCover
    {
        public int PolicyCoverId { get; set; }
        public string Code { get; set; }
        public decimal Premium { get; set; }
        public int PolicyValidityPeriodId { get; set; }
        public int PolicyVersionId { get; set; }

        public virtual PolicyValidityPeriod PolicyValidityPeriod { get; set; }
        public virtual PolicyVersion PolicyVersion { get; set; }
    }
}