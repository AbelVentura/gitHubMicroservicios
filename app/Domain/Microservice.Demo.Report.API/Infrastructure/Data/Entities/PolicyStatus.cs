﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Microservice.Demo.Report.API.Data.Entities
{
    public partial class PolicyStatus
    {
        public PolicyStatus()
        {
            Policies = new HashSet<Policy>();
        }

        public int PolicyStatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }
    }
}