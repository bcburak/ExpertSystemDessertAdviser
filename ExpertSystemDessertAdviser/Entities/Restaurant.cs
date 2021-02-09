﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Entities
{
    public class Restaurant : BaseEntity
    {
        public string Title { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<Desert> Deserts { get; set; }
    }
}
