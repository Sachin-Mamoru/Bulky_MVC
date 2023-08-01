using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CW2.Migrations
{
    /// <inheritdoc />
    public partial class addWorkout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutDuration = table.Column<int>(type: "int", nullable: false),
                    WorkoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheatMeal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CheatMeal", "WeightValue", "WorkoutDate", "WorkoutDuration", "WorkoutType" },
                values: new object[,]
                {
                    { 1, "Snack", 70, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Legs" },
                    { 2, "Rolls", 72, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Shoulders" },
                    { 3, "Pizza", 80, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Chest" },
                    { 4, "Burger", 85, new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Back" },
                    { 5, "Ice Cream", 68, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Arms" },
                    { 6, "Fries", 75, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Legs" },
                    { 7, "Cake", 70, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Shoulders" },
                    { 8, "Donuts", 78, new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Chest" },
                    { 9, "Chips", 83, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Back" },
                    { 10, "Cookies", 66, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Arms" },
                    { 11, "Chocolate", 72, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Legs" },
                    { 12, "Popcorn", 69, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Shoulders" },
                    { 13, "Pasta", 79, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Chest" },
                    { 14, "Nachos", 82, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Back" },
                    { 15, "Soda", 65, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Arms" },
                    { 16, "Cheese", 73, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Legs" },
                    { 17, "Noodles", 68, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Shoulders" },
                    { 18, "Waffles", 77, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Chest" },
                    { 19, "Pancakes", 81, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Back" },
                    { 20, "Sushi", 67, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Arms" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
