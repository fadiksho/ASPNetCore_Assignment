﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETCore_Assignments.Migrations
{
	public partial class FirstIntials : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
					name: "Students",
					columns: table => new
					{
						Id = table.Column<int>(nullable: false)
									.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
						Name = table.Column<string>(nullable: true)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Students", x => x.Id);
					});

			migrationBuilder.CreateTable(
					name: "Teachers",
					columns: table => new
					{
						Id = table.Column<int>(nullable: false)
									.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
						Name = table.Column<string>(nullable: true)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Teachers", x => x.Id);
					});

			migrationBuilder.CreateTable(
					name: "Courses",
					columns: table => new
					{
						Id = table.Column<int>(nullable: false)
									.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
						Name = table.Column<string>(nullable: true),
						Description = table.Column<string>(nullable: true),
						TeacherId = table.Column<int>(nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Courses", x => x.Id);
						table.ForeignKey(
											name: "FK_Courses_Teachers_TeacherId",
											column: x => x.TeacherId,
											principalTable: "Teachers",
											principalColumn: "Id",
											onDelete: ReferentialAction.Cascade);
					});

			migrationBuilder.CreateTable(
					name: "CourseAssignments",
					columns: table => new
					{
						Id = table.Column<int>(nullable: false)
									.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
						Name = table.Column<string>(nullable: true),
						IsDone = table.Column<bool>(nullable: false),
						CourseId = table.Column<int>(nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_CourseAssignments", x => x.Id);
						table.ForeignKey(
											name: "FK_CourseAssignments_Courses_CourseId",
											column: x => x.CourseId,
											principalTable: "Courses",
											principalColumn: "Id",
											onDelete: ReferentialAction.Cascade);
					});

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
					name: "IX_CourseAssignments_CourseId",
					table: "CourseAssignments",
					column: "CourseId");

			migrationBuilder.CreateIndex(
					name: "IX_Courses_TeacherId",
					table: "Courses",
					column: "TeacherId");

			migrationBuilder.CreateIndex(
					name: "IX_StudentCourse_CourseId",
					table: "StudentCourse",
					column: "CourseId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "CourseAssignments");

			migrationBuilder.DropTable(
					name: "StudentCourse");

			migrationBuilder.DropTable(
					name: "Courses");

			migrationBuilder.DropTable(
					name: "Students");

			migrationBuilder.DropTable(
					name: "Teachers");
		}
	}
}
