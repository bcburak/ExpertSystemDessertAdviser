using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Entities
{
    public class Meal : BaseEntity
    {
        public string Name { get; set; }
        public string MealType { get; set; }
        public bool MealAdviser { get; set; }

        public Restaurant Restaurants { get; set; }

    }
}
