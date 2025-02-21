using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS1_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class relationbatweenCoursetopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "Topic",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topic_courseId",
                table: "Topic",
                column: "courseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Courses_courseId",
                table: "Topic",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Courses_courseId",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_courseId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "Topic");
        }
    }
}
