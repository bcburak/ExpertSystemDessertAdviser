using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Entities
{
    public class MealType : BaseEntity
    {
        public int Name { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}
