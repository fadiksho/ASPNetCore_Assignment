﻿// <auto-generated />
using System;
using ASPNETCore_Assignments.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNETCore_Assignments.Migrations
{
  [DbContext(typeof(SchoolManagementContext))]
  [Migration("20190404091823_ChangeDeleteBehavaiorOfTeacherEntity")]
  partial class ChangeDeleteBehavaiorOfTeacherEntity
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
          .HasAnnotation("Relational:MaxIdentifierLength", 128)
          .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.CourseAssignmentEntity", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<int>("CourseId");

            b.Property<bool>("IsDone");

            b.Property<string>("Name");

            b.HasKey("Id");

            b.HasIndex("CourseId");

            b.ToTable("CourseAssignments");
          });

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.CourseEntity", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("Description");

            b.Property<string>("Name");

            b.Property<int?>("TeacherId");

            b.HasKey("Id");

            b.HasIndex("TeacherId");

            b.ToTable("Courses");
          });

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.StudentCourseEntity", b =>
          {
            b.Property<int>("StudentId");

            b.Property<int>("CourseId");

            b.HasKey("StudentId", "CourseId");

            b.HasIndex("CourseId");

            b.ToTable("StudentCourseEntity");
          });

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.StudentEntity", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("Name");

            b.HasKey("Id");

            b.ToTable("Students");
          });

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.TeacherEntity", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("Name");

            b.HasKey("Id");

            b.ToTable("Teachers");
          });

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.CourseAssignmentEntity", b =>
          {
            b.HasOne("ASPNETCore_Assignments.Entity.CourseEntity", "Course")
                      .WithMany("CourseAssignments")
                      .HasForeignKey("CourseId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.CourseEntity", b =>
          {
            b.HasOne("ASPNETCore_Assignments.Entity.TeacherEntity", "Teacher")
                      .WithMany("Courses")
                      .HasForeignKey("TeacherId")
                      .OnDelete(DeleteBehavior.SetNull);
          });

      modelBuilder.Entity("ASPNETCore_Assignments.Entity.StudentCourseEntity", b =>
          {
            b.HasOne("ASPNETCore_Assignments.Entity.CourseEntity", "Course")
                      .WithMany("StudentCourses")
                      .HasForeignKey("CourseId")
                      .OnDelete(DeleteBehavior.Cascade);

            b.HasOne("ASPNETCore_Assignments.Entity.StudentEntity", "Student")
                      .WithMany("StudentCourses")
                      .HasForeignKey("StudentId")
                      .OnDelete(DeleteBehavior.Cascade);
          });
#pragma warning restore 612, 618
    }
  }
}
