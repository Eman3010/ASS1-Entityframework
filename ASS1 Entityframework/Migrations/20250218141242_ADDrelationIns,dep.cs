using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS1_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class ADDrelationInsdep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsID",
                table: "Ddepartments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Ddepartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ddepartments_InstructorId",
                table: "Ddepartments",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ddepartments_Instructors_InstructorId",
                table: "Ddepartments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ddepartments_Instructors_InstructorId",
                table: "Ddepartments");

            migrationBuilder.DropIndex(
                name: "IX_Ddepartments_InstructorId",
                table: "Ddepartments");

            migrationBuilder.DropColumn(
                name: "InsID",
                table: "Ddepartments");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Ddepartments");
        }
    }
}
