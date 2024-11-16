using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ResponseWorkoutMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkoutGenerateResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetMuscleGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutGenerateRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutGenerateResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutGenerateResponses_WorkoutGenerateRequests_WorkoutGenerateRequestId",
                        column: x => x.WorkoutGenerateRequestId,
                        principalTable: "WorkoutGenerateRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WorkoutGenerateResponses",
                columns: new[] { "Id", "ExerciseDuration", "ExerciseName", "TargetMuscleGroup", "WorkoutGenerateRequestId" },
                values: new object[,]
                {
                    { 1, "30 minutes", "Exercise", "Muscle Group", 1 },
                    { 2, "30 minutes", "Exercise", "Muscle Group", 2 },
                    { 3, "30 minutes", "Exercise", "Muscle Group", 3 },
                    { 4, "20 minutes", "Treadmill Jogging", "Cardio", 4 },
                    { 5, "15 minutes", "Advanced Treadmill Sprints", "Cardio", 5 },
                    { 6, "30 minutes", "HIIT Circuit", "Full Body", 6 },
                    { 7, "15 minutes", "Resistance Band Squats", "Legs", 7 },
                    { 8, "15 minutes", "Resistance Band Deadlifts", "Back", 8 },
                    { 9, "20 minutes", "Advanced Band Lunges", "Legs", 9 },
                    { 10, "20 minutes", "Leg Press", "Legs", 10 },
                    { 11, "20 minutes", "Chest Press Machine", "Chest", 11 },
                    { 12, "20 minutes", "Pull-Down Machine", "Back", 12 },
                    { 13, "30 minutes", "Bodyweight Circuit", "Full Body", 13 },
                    { 14, "15 minutes", "Mountain Climbers", "Core", 14 },
                    { 15, "15 minutes", "Burpees", "Full Body", 15 },
                    { 16, "20 minutes", "Incline Walking", "Cardio", 16 },
                    { 17, "25 minutes", "Treadmill Intervals", "Cardio", 17 },
                    { 18, "20 minutes", "Treadmill HIIT", "Cardio", 18 },
                    { 19, "20 minutes", "Band High Knees", "Cardio", 19 },
                    { 20, "20 minutes", "Band Side Steps", "Legs", 20 },
                    { 21, "20 minutes", "Band Glute Kickbacks", "Glutes", 21 },
                    { 22, "25 minutes", "Rowing Machine", "Full Body", 22 },
                    { 23, "30 minutes", "Elliptical Machine", "Full Body", 23 },
                    { 24, "30 minutes", "Cycling Machine", "Legs", 24 },
                    { 25, "10 minutes", "Jump Rope", "Cardio", 25 },
                    { 26, "20 minutes", "Stair Climbers", "Cardio", 26 },
                    { 27, "15 minutes", "Advanced Jump Squats", "Legs", 27 },
                    { 28, "30 minutes", "Treadmill Walk/Jog", "Cardio", 28 },
                    { 29, "25 minutes", "Advanced Treadmill Jogging", "Cardio", 29 },
                    { 30, "30 minutes", "HIIT on Treadmill", "Cardio", 30 },
                    { 31, "15 minutes", "Band-Assisted Pull-ups", "Back", 31 },
                    { 32, "20 minutes", "Band Push-ups", "Chest", 32 },
                    { 33, "15 minutes", "Band Rows", "Back", 33 },
                    { 34, "20 minutes", "Weight Machines Warmup", "Full Body", 34 },
                    { 35, "20 minutes", "Advanced Free Weights", "Arms", 35 },
                    { 36, "25 minutes", "Weight Machine Rotations", "Core", 36 },
                    { 37, "15 minutes", "Dynamic Stretches", "Full Body", 37 },
                    { 38, "30 minutes", "Yoga Beginner Flow", "Flexibility", 38 },
                    { 39, "35 minutes", "Intermediate Yoga", "Flexibility", 39 },
                    { 40, "10 minutes", "Treadmill Stretches", "Legs", 40 },
                    { 41, "10 minutes", "Treadmill Cooldown", "Full Body", 41 },
                    { 42, "15 minutes", "Treadmill Side Steps", "Legs", 42 },
                    { 43, "15 minutes", "Band Assisted Warm-ups", "Legs", 43 },
                    { 44, "15 minutes", "Band Cooldown", "Flexibility", 44 },
                    { 45, "10 minutes", "Band Core Rotations", "Core", 45 },
                    { 46, "20 minutes", "Weight Machine Warmups", "Full Body", 46 },
                    { 47, "25 minutes", "Weight Machines Flexibility", "Flexibility", 47 },
                    { 48, "30 minutes", "Advanced Stretching", "Full Body", 48 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutGenerateResponses_WorkoutGenerateRequestId",
                table: "WorkoutGenerateResponses",
                column: "WorkoutGenerateRequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutGenerateResponses");
        }
    }
}
