using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS1_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class onetomanyrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DdepartmentID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "deptID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DdepartmentID",
                table: "Students",
                column: "DdepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Ddepartments_DdepartmentID",
                table: "Students",
                column: "DdepartmentID",
                principalTable: "Ddepartments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Ddepartments_DdepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DdepartmentID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DdepartmentID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "deptID",
                table: "Students");
        }
    }
}
