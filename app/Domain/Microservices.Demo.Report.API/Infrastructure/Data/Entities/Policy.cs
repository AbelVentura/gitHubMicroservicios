﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public partial class Policy
    {
        public Policy()
        {
            PolicyVersions = new HashSet<PolicyVersion>();
        }

        public int PolicyId { get; set; }
        public string Number { get; set; }
        public string ProductCode { get; set; }
        public string AgentLogin { get; set; }
        public int PolicyStatusId { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual PolicyStatus PolicyStatus { get; set; }
        public virtual ICollection<PolicyVersion> PolicyVersions { get; set; }
    }
}