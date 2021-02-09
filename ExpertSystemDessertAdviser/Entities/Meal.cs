namespace ExpertSystemDessertAdviser.Entities
{
    public class Meal : BaseEntity
    {
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
