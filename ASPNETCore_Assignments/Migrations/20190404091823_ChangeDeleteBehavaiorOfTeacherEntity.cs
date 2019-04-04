using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETCore_Assignments.Migrations
{
  public partial class ChangeDeleteBehavaiorOfTeacherEntity : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Courses_Teachers_TeacherId",
          table: "Courses");

      migrationBuilder.AddForeignKey(
          name: "FK_Courses_Teachers_TeacherId",
          table: "Courses",
          column: "TeacherId",
          principalTable: "Teachers",
          principalColumn: "Id",
          onDelete: ReferentialAction.SetNull);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Courses_Teachers_TeacherId",
          table: "Courses");

      migrationBuilder.AddForeignKey(
          name: "FK_Courses_Teachers_TeacherId",
          table: "Courses",
          column: "TeacherId",
          principalTable: "Teachers",
          principalColumn: "Id",
          onDelete: ReferentialAction.Restrict);
    }
  }
}
