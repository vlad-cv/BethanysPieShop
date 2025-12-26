namespace BethanysPieShop.Models
{
    // Pie class representing a pie entity in the application
    public class Pie
    {
        // Unique identifier for the pie
        public int PieId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }

        // Navigation property to the Category entity
        public virtual Category? Category { get; set; } = default!;


    }
}
