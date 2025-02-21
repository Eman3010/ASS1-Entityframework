using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS1_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class kjj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ddepartmentID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "deptId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ddepartmentID",
                table: "Instructors",
                column: "ddepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Ddepartments_ddepartmentID",
                table: "Instructors",
                column: "ddepartmentID",
                principalTable: "Ddepartments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Ddepartments_ddepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ddepartmentID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "ddepartmentID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "deptId",
                table: "Instructors");
        }
    }
}
