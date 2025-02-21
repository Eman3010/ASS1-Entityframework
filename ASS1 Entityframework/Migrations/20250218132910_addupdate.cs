using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS1_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class addupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Top_ID",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "Ddepartments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ddepartments", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ddepartments");

            migrationBuilder.AddColumn<int>(
                name: "Dep_Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Top_ID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
