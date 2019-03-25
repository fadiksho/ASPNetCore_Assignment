using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETCore_Assignments.Migrations
{
	public partial class MakeRelationshipBetweenTeacherAndCoursesOptional : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
					name: "FK_Courses_Teachers_TeacherId",
					table: "Courses");

			migrationBuilder.AlterColumn<int>(
					name: "TeacherId",
					table: "Courses",
					nullable: true,
					oldClrType: typeof(int));

			migrationBuilder.AddForeignKey(
					name: "FK_Courses_Teachers_TeacherId",
					table: "Courses",
					column: "TeacherId",
					principalTable: "Teachers",
					principalColumn: "Id",
					onDelete: ReferentialAction.Restrict);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
					name: "FK_Courses_Teachers_TeacherId",
					table: "Courses");

			migrationBuilder.AlterColumn<int>(
					name: "TeacherId",
					table: "Courses",
					nullable: false,
					oldClrType: typeof(int),
					oldNullable: true);

			migrationBuilder.AddForeignKey(
					name: "FK_Courses_Teachers_TeacherId",
					table: "Courses",
					column: "TeacherId",
					principalTable: "Teachers",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
		}
	}
}
