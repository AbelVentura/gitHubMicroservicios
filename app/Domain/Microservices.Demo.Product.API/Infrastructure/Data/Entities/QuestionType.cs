﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservices.Demo.Product.API.Infrastructure.Data.Entities
{
    public partial class QuestionType
    {
        public QuestionType()
        {
            Questions = new HashSet<Question>();
        }

        public int QuestionTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}