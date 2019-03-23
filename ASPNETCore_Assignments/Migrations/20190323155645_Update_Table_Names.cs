﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETCore_Assignments.Migrations
{
	public partial class Update_Table_Names : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "StudentCourse");

			migrationBuilder.CreateTable(
					name: "StudentCourseEntity",
					columns: table => new
					{
						StudentId = table.Column<int>(nullable: false),
						CourseId = table.Column<int>(nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_StudentCourseEntity", x => new { x.StudentId, x.CourseId });
						table.ForeignKey(
											name: "FK_StudentCourseEntity_Courses_CourseId",
											column: x => x.CourseId,
											principalTable: "Courses",
											principalColumn: "Id",
											onDelete: ReferentialAction.Cascade);
						table.ForeignKey(
											name: "FK_StudentCourseEntity_Students_StudentId",
											column: x => x.StudentId,
											principalTable: "Students",
											principalColumn: "Id",
											onDelete: ReferentialAction.Cascade);
					});

			migrationBuilder.CreateIndex(
					name: "IX_StudentCourseEntity_CourseId",
					table: "StudentCourseEntity",
					column: "CourseId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "StudentCourseEntity");

			migrationBuilder.CreateTable(
					name: "StudentCourse",
					columns: table => new
					{
						StudentId = table.Column<int>(nullable: false),
						CourseId = table.Column<int>(nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_StudentCourse", x => new { x.StudentId, x.CourseId });
						table.ForeignKey(
											name: "FK_StudentCourse_Courses_CourseId",
											column: x => x.CourseId,
											principalTable: "Courses",
											principalColumn: "Id",
											onDelete: ReferentialAction.Cascade);
						table.ForeignKey(
											name: "FK_StudentCourse_Students_StudentId",
											column: x => x.StudentId,
											principalTable: "Students",
											principalColumn: "Id",
											onDelete: ReferentialAction.Cascade);
					});

			migrationBuilder.CreateIndex(
					name: "IX_StudentCourse_CourseId",
					table: "StudentCourse",
					column: "CourseId");
		}
	}
}
