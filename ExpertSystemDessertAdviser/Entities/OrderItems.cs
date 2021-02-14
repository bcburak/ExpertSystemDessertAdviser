using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Entities
{
    public class OrderItems : BaseEntity
    {
        public int OrderId { get; set; }
        public int MealId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Meal Meal { get; set; }

    }
}
