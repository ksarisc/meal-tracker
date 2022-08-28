using System.ComponentModel.DataAnnotations;

namespace MealTracker.Models
{
    public class MealItem
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

        public int Calories { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
