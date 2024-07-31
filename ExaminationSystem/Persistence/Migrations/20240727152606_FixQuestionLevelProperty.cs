using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixQuestionLevelProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ChoiceLevels_ExamLevelId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExamLevelId",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "QuestionLevelId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionLevelId",
                table: "Questions",
                column: "QuestionLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_ChoiceLevels_QuestionLevelId",
                table: "Questions",
                column: "QuestionLevelId",
                principalTable: "ChoiceLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ChoiceLevels_QuestionLevelId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionLevelId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionLevelId",
                table: "Questions");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamLevelId",
                table: "Questions",
                column: "ExamLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_ChoiceLevels_ExamLevelId",
                table: "Questions",
                column: "ExamLevelId",
                principalTable: "ChoiceLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
