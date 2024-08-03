using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Exam_Title : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16096978-d3a5-45be-bb63-4e05428a8ac9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENg1YNyZwDTiN1671zRpHxoM7EfNu/HDEZCWRbeMxPeZCs9DvLBfCPD6dcRYYtQgiA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Exams");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16096978-d3a5-45be-bb63-4e05428a8ac9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJhkYTzC4H4lRoGeLpUg5RQRqWNVzntxYyOx0GdEusLCXgphEtrwjjIw5HvDncH6Tg==");
        }
    }
}
