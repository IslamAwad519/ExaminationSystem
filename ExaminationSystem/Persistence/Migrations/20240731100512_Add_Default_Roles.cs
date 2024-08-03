using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Default_Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fdf8fc8c-d111-4eb6-8259-31da89d71f93", "16096978-d3a5-45be-bb63-4e05428a8ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16096978-d3a5-45be-bb63-4e05428a8ac9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJhkYTzC4H4lRoGeLpUg5RQRqWNVzntxYyOx0GdEusLCXgphEtrwjjIw5HvDncH6Tg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fdf8fc8c-d111-4eb6-8259-31da89d71f93", "16096978-d3a5-45be-bb63-4e05428a8ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16096978-d3a5-45be-bb63-4e05428a8ac9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECubtq/yYGI2iko03dp7WYCZAr2zNgUjTcC5b9yPTXVXNCSyBZaPotsYtRUfdUdRUA==");
        }
    }
}
