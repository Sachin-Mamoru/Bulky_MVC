
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CW2.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Workout Type")]
        public string WorkoutType { get; set; }
        [DisplayName("Workout Duration")]
        [Range(10,40,ErrorMessage ="Display Order must be between 10 minutes- 40 minutes")]
        public int WorkoutDuration { get; set; }

        [DisplayName("Workout Date")]
        public DateTime WorkoutDate { get; set; } = DateTime.Today;

        [DisplayName("Cheat Meal")]
        public string CheatMeal { get; set; }

        [DisplayName("Weight Value")]
        public int WeightValue { get; set; }
    }
}
