using System.Collections.Generic;

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
