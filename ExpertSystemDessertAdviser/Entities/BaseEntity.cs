using System.ComponentModel.DataAnnotations;

namespace ExpertSystemDessertAdviser.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
