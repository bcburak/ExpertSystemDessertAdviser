using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExpertSystemDessertAdviser.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        public string Note { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
