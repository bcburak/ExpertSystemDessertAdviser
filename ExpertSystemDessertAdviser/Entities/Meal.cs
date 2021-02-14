using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Entities
{
    public class Meal : BaseEntity
    {
        public string Title { get; set; }
        public MealType MealType { get; set; }
        public int MealTypeId { get; set; }
        public bool IsSpecial { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }

    }
}
