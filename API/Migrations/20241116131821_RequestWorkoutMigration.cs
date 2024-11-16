using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class RequestWorkoutMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkoutGenerateRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FitnessLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutGenerateRequests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WorkoutGenerateRequests",
                columns: new[] { "Id", "Equipment", "FitnessLevel", "Goal" },
                values: new object[,]
                {
                    { 1, "None", "Beginner", "BuildMuscles" },
                    { 2, "None", "Intermediate", "BuildMuscles" },
                    { 3, "None", "Advanced", "BuildMuscles" },
                    { 4, "TreadMill", "Beginner", "BuildMuscles" },
                    { 5, "TreadMill", "Intermediate", "BuildMuscles" },
                    { 6, "TreadMill", "Advanced", "BuildMuscles" },
                    { 7, "Bands", "Beginner", "BuildMuscles" },
                    { 8, "Bands", "Intermediate", "BuildMuscles" },
                    { 9, "Bands", "Advanced", "BuildMuscles" },
                    { 10, "WeightMachines", "Beginner", "BuildMuscles" },
                    { 11, "WeightMachines", "Intermediate", "BuildMuscles" },
                    { 12, "WeightMachines", "Advanced", "BuildMuscles" },
                    { 13, "None", "Beginner", "LoseWeight" },
                    { 14, "None", "Intermediate", "LoseWeight" },
                    { 15, "None", "Advanced", "LoseWeight" },
                    { 16, "TreadMill", "Beginner", "LoseWeight" },
                    { 17, "TreadMill", "Intermediate", "LoseWeight" },
                    { 18, "TreadMill", "Advanced", "LoseWeight" },
                    { 19, "Bands", "Beginner", "LoseWeight" },
                    { 20, "Bands", "Intermediate", "LoseWeight" },
                    { 21, "Bands", "Advanced", "LoseWeight" },
                    { 22, "WeightMachines", "Beginner", "LoseWeight" },
                    { 23, "WeightMachines", "Intermediate", "LoseWeight" },
                    { 24, "WeightMachines", "Advanced", "LoseWeight" },
                    { 25, "None", "Beginner", "IncreaseEndurance" },
                    { 26, "None", "Intermediate", "IncreaseEndurance" },
                    { 27, "None", "Advanced", "IncreaseEndurance" },
                    { 28, "TreadMill", "Beginner", "IncreaseEndurance" },
                    { 29, "TreadMill", "Intermediate", "IncreaseEndurance" },
                    { 30, "TreadMill", "Advanced", "IncreaseEndurance" },
                    { 31, "Bands", "Beginner", "IncreaseEndurance" },
                    { 32, "Bands", "Intermediate", "IncreaseEndurance" },
                    { 33, "Bands", "Advanced", "IncreaseEndurance" },
                    { 34, "WeightMachines", "Beginner", "IncreaseEndurance" },
                    { 35, "WeightMachines", "Intermediate", "IncreaseEndurance" },
                    { 36, "WeightMachines", "Advanced", "IncreaseEndurance" },
                    { 37, "None", "Beginner", "ImproveFlexibility" },
                    { 38, "None", "Intermediate", "ImproveFlexibility" },
                    { 39, "None", "Advanced", "ImproveFlexibility" },
                    { 40, "TreadMill", "Beginner", "ImproveFlexibility" },
                    { 41, "TreadMill", "Intermediate", "ImproveFlexibility" },
                    { 42, "TreadMill", "Advanced", "ImproveFlexibility" },
                    { 43, "Bands", "Beginner", "ImproveFlexibility" },
                    { 44, "Bands", "Intermediate", "ImproveFlexibility" },
                    { 45, "Bands", "Advanced", "ImproveFlexibility" },
                    { 46, "WeightMachines", "Beginner", "ImproveFlexibility" },
                    { 47, "WeightMachines", "Intermediate", "ImproveFlexibility" },
                    { 48, "WeightMachines", "Advanced", "ImproveFlexibility" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutGenerateRequests");
        }
    }
}
