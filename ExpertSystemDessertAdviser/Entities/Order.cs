using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExpertSystemDessertAdviser.Entities
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public string Detail { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }

    }
}
