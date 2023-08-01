using CW2.Models;
using Microsoft.EntityFrameworkCore;

namespace CW2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workout>().HasData(
                new Workout { Id = 1, WorkoutType = "Legs", WorkoutDuration = 40, WorkoutDate = new DateTime(2023, 7, 23), CheatMeal = "Snack", WeightValue = 70 },
                new Workout { Id = 2, WorkoutType = "Shoulders", WorkoutDuration = 30, WorkoutDate = new DateTime(2023, 7, 24), CheatMeal = "Rolls", WeightValue = 72 },
                new Workout { Id = 3, WorkoutType = "Chest", WorkoutDuration = 45, WorkoutDate = new DateTime(2023, 7, 25), CheatMeal = "Pizza", WeightValue = 80 },
                new Workout { Id = 4, WorkoutType = "Back", WorkoutDuration = 35, WorkoutDate = new DateTime(2023, 7, 26), CheatMeal = "Burger", WeightValue = 85 },
                new Workout { Id = 5, WorkoutType = "Arms", WorkoutDuration = 30, WorkoutDate = new DateTime(2023, 7, 27), CheatMeal = "Ice Cream", WeightValue = 68 },
                new Workout { Id = 6, WorkoutType = "Legs", WorkoutDuration = 50, WorkoutDate = new DateTime(2023, 7, 28), CheatMeal = "Fries", WeightValue = 75 },
                new Workout { Id = 7, WorkoutType = "Shoulders", WorkoutDuration = 30, WorkoutDate = new DateTime(2023, 7, 29), CheatMeal = "Cake", WeightValue = 70 },
                new Workout { Id = 8, WorkoutType = "Chest", WorkoutDuration = 45, WorkoutDate = new DateTime(2023, 7, 30), CheatMeal = "Donuts", WeightValue = 78 },
                new Workout { Id = 9, WorkoutType = "Back", WorkoutDuration = 50, WorkoutDate = new DateTime(2023, 7, 31), CheatMeal = "Chips", WeightValue = 83 },
                new Workout { Id = 10, WorkoutType = "Arms", WorkoutDuration = 35, WorkoutDate = new DateTime(2023, 8, 1), CheatMeal = "Cookies", WeightValue = 66 },
                new Workout { Id = 11, WorkoutType = "Legs", WorkoutDuration = 40, WorkoutDate = new DateTime(2023, 8, 2), CheatMeal = "Chocolate", WeightValue = 72 },
                new Workout { Id = 12, WorkoutType = "Shoulders", WorkoutDuration = 30, WorkoutDate = new DateTime(2023, 8, 3), CheatMeal = "Popcorn", WeightValue = 69 },
                new Workout { Id = 13, WorkoutType = "Chest", WorkoutDuration = 45, WorkoutDate = new DateTime(2023, 8, 4), CheatMeal = "Pasta", WeightValue = 79 },
                new Workout { Id = 14, WorkoutType = "Back", WorkoutDuration = 25, WorkoutDate = new DateTime(2023, 8, 5), CheatMeal = "Nachos", WeightValue = 82 },
                new Workout { Id = 15, WorkoutType = "Arms", WorkoutDuration = 35, WorkoutDate = new DateTime(2023, 8, 6), CheatMeal = "Soda", WeightValue = 65 },
                new Workout { Id = 16, WorkoutType = "Legs", WorkoutDuration = 40, WorkoutDate = new DateTime(2023, 8, 7), CheatMeal = "Cheese", WeightValue = 73 },
                new Workout { Id = 17, WorkoutType = "Shoulders", WorkoutDuration = 30, WorkoutDate = new DateTime(2023, 8, 8), CheatMeal = "Noodles", WeightValue = 68 },
                new Workout { Id = 18, WorkoutType = "Chest", WorkoutDuration = 45, WorkoutDate = new DateTime(2023, 8, 9), CheatMeal = "Waffles", WeightValue = 77 },
                new Workout { Id = 19, WorkoutType = "Back", WorkoutDuration = 25, WorkoutDate = new DateTime(2023, 8, 10), CheatMeal = "Pancakes", WeightValue = 81 },
                new Workout { Id = 20, WorkoutType = "Arms", WorkoutDuration = 35, WorkoutDate = new DateTime(2023, 8, 11), CheatMeal = "Sushi", WeightValue = 67 }
                );
        }
    }
}
