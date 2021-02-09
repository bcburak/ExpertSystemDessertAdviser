using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Entities
{
    public class Desert : BaseEntity
    {
        public int ResaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
