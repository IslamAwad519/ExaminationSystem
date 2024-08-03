using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExaminationSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Default_Roles_And_Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "IsDefault", "IsDeleted", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4eed41ca-cd80-463b-995b-3371c972e638", "d100e61d-33d4-47e3-9ec4-6426e640c44b", true, false, "Student", "STUDENT" },
                    { "d9c493be-9039-48e7-8814-f6eca41cc21a", "28413dd7-5b4b-4931-80fa-521184425050", false, false, "Instructor", "INSTRUCTOR" },
                    { "fdf8fc8c-d111-4eb6-8259-31da89d71f93", "be8d8ccc-c1cf-4d14-bafb-1d1f9012b803", false, false, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "16096978-d3a5-45be-bb63-4e05428a8ac9", 0, "3b3ae3f5-437d-42dc-8b29-bae6304552fc", "admin@test.com", true, "Admin", "Test", false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAECubtq/yYGI2iko03dp7WYCZAr2zNgUjTcC5b9yPTXVXNCSyBZaPotsYtRUfdUdRUA==", null, false, "71E18D851D214F5B96D32DA0E566B629", false, "admin@test.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eed41ca-cd80-463b-995b-3371c972e638");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9c493be-9039-48e7-8814-f6eca41cc21a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdf8fc8c-d111-4eb6-8259-31da89d71f93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16096978-d3a5-45be-bb63-4e05428a8ac9");
        }
    }
}
