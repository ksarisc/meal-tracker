using System.ComponentModel.DataAnnotations;

namespace MealTracker.Models
{
    public class MealItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 2)]
        public string Description { get; set; } = string.Empty;

        public int Calories { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string CreatedBy { get; set; } = string.Empty;
    }
}
