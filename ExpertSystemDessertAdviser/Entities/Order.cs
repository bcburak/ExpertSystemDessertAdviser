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
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public string Detail { get; set; }

        public int RestaurantId { get; set; }

    }
}
