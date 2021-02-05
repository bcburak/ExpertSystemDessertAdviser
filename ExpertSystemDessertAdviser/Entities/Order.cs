using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Entities
{
    public class Order : BaseEntity
    {
        public Restaurant Restaurant { get; set; }

        public User User{ get; set; }
        public DateTime OrderDate { get; set; }
        public string Detail { get; set; }

    }
}
