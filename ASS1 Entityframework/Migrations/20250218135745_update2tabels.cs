using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS1_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class update2tabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "topId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "topicId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_topicId",
                table: "Courses",
                column: "topicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topic_topicId",
                table: "Courses",
                column: "topicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topic_topicId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_topicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "topId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "topicId",
                table: "Courses");

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
    }
}
