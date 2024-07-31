using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Extensd_BaseAuditableEntity_andOverride_SaveChangesAsync : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "Students",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "Results",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "Questions",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "Instructors",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "Exams",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "Courses",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "Choices",
                newName: "UpdatedOn");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Students",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Results",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Results",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Questions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Questions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Exams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Exams",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Choices",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Choices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CreatedById",
                table: "Students",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UpdatedById",
                table: "Students",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Results_CreatedById",
                table: "Results",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Results_UpdatedById",
                table: "Results",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CreatedById",
                table: "Questions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UpdatedById",
                table: "Questions",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CreatedById",
                table: "Instructors",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UpdatedById",
                table: "Instructors",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CreatedById",
                table: "Exams",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UpdatedById",
                table: "Exams",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CreatedById",
                table: "Courses",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UpdatedById",
                table: "Courses",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Choices_CreatedById",
                table: "Choices",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Choices_UpdatedById",
                table: "Choices",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_AspNetUsers_CreatedById",
                table: "Choices",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_AspNetUsers_UpdatedById",
                table: "Choices",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_CreatedById",
                table: "Courses",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_UpdatedById",
                table: "Courses",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_AspNetUsers_CreatedById",
                table: "Exams",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_AspNetUsers_UpdatedById",
                table: "Exams",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_AspNetUsers_CreatedById",
                table: "Instructors",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_AspNetUsers_UpdatedById",
                table: "Instructors",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AspNetUsers_CreatedById",
                table: "Questions",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AspNetUsers_UpdatedById",
                table: "Questions",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_AspNetUsers_CreatedById",
                table: "Results",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_AspNetUsers_UpdatedById",
                table: "Results",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_CreatedById",
                table: "Students",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UpdatedById",
                table: "Students",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_AspNetUsers_CreatedById",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Choices_AspNetUsers_UpdatedById",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_CreatedById",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_UpdatedById",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_AspNetUsers_CreatedById",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_AspNetUsers_UpdatedById",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_AspNetUsers_CreatedById",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_AspNetUsers_UpdatedById",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AspNetUsers_CreatedById",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AspNetUsers_UpdatedById",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_AspNetUsers_CreatedById",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_AspNetUsers_UpdatedById",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_CreatedById",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UpdatedById",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CreatedById",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UpdatedById",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Results_CreatedById",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_UpdatedById",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CreatedById",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_UpdatedById",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_CreatedById",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_UpdatedById",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CreatedById",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_UpdatedById",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CreatedById",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UpdatedById",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Choices_CreatedById",
                table: "Choices");

            migrationBuilder.DropIndex(
                name: "IX_Choices_UpdatedById",
                table: "Choices");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Choices");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Choices");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Students",
                newName: "LastUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Results",
                newName: "LastUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Questions",
                newName: "LastUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Instructors",
                newName: "LastUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Exams",
                newName: "LastUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Courses",
                newName: "LastUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Choices",
                newName: "LastUpdatedOn");
        }
    }
}
