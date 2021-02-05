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
        public string MealType { get; set; }
        public bool MealAdviser { get; set; }

        public virtual int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

    }
}
