﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExpertSystemDessertAdviser.Entities
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int ProductId { get; set; }

        // false if it's not a meal
        public bool isMeal { get; set; }

        public int Amount { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
