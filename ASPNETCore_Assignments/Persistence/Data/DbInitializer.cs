using ASPNETCore_Assignments.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Persistence.Data
{
	public static class DbInitializer
	{
		public static void Initialize(SchoolManagementContext context)
		{
			context.Database.EnsureCreated();

			if (context.Courses.Any())
			{
				return;
			}

			// Intialize 5 students
			var students = new[]
			{
				new StudentEntity { Name = "Fadi" },
				new StudentEntity { Name = "Dodo" },
				new StudentEntity { Name = "Koko" },
				new StudentEntity { Name = "Lolo" },
				new StudentEntity { Name = "Mimo" }
			};

			// Intialize 9 courses with the assignments for each course
			var courses = new[]
			{
				new CourseEntity
				{
					Name = "Programming I (ID1018)",
					Description = "The course runs over a KTH period.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "LABA - Laboratory Work", IsDone = false},
						new CourseAssignmentEntity() { Name = "TENA - Examination", IsDone = false}
					}
				},
				new CourseEntity
				{
					Name = "IE1204 Digital Design",
					Description = "Number System and Codes. Binary Arithmetic. Booolean algebra and Booolean functions. Logic operations. Logic gates. Optimisation methods. Combinational function blocks. Digital arithmetic. Design of combinational circuits. Latches and Flips-Flops. Counters. Sequential circuits. Finite state diagrams. Finite state machine of Mealy and Moore type. Asynchronous sequential circuits. Design of synchronous and asynchronous sequential circuits. Programmable logic. Introduction to VHDL. Memory. Fundamental MOS-technology.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 3", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 4", IsDone = false},
					}
				},
				new CourseEntity
				{
					Name = "IE1206 Embedded Electronics",
					Description = "This course provides basic knowledge of circuit theory and electronics. It also provides knowledge of the various devices that can be found in a microcontroller and how these are supposed to be used.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
					}
				},
				new CourseEntity
				{
					Name = "II1306 Introduction to IT",
					Description = "The course includes planning, implementing of smaller projects with a traditional project methodology with application in a simple project. Writing of simple reports/summaries with correct reference management. Discussions and reflections around study techniques and different methods to manage his/her studies at KTH in a good way.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
					}
				},
				new CourseEntity
				{
					Name = "IS1200 Computer Hardware Engineering",
					Description = "The course gives fundamental knowledge of computer organization, both from a hardware and software perspective. The course is organized in six modules that include, among other things.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 3", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 4", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 5", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 6", IsDone = false},
					}
				},
				new CourseEntity
				{
					Name = "SF1610 Discrete Mathematics",
					Description = "TThe fundamental theorem of arithmetics, the Euclidian algorithm and a Diophantine equation. Modular arithmetics, Fermat's theorem and RSA. Sets, functions, infinite sets and cardinal numbers, the pigeonhole principle. Proof by induction and recursions. Elementary group theory as the theorem of Lagrange and in particular the symmetrical group. Boolean algebra. Error correcting codes and in particular Hamming codes. Combinatorics, binomial and multinomial numbers, Stirling numbers, the sieve principle. Elementary graph theory, Eulerian and Hamiltonian graphs, matchings in bipartite graphs, planar graphs.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
					}
				},
				new CourseEntity
				{
					Name = "SF1685 Calculus in One Variable",
					Description = "Function, function graph, domain, range. Increasing and decreasing functions, odd and even functions. Inverse functions. The class of elementary functions. Unit circle, trigonometric formulas and equations, exponential and logarithmic functions, power laws, logarithms. Limits, rules for calculating limits, standard limits. Continuity, theorems on continuous functions. Derivative, rules of differentiation and applications: rate of change, linear approximation, tangent, extreme value problems, sketching the graph of a function, inequalities etc.Taylor's formula with error estimates. Linear differential equations with constant coefficients and their applications. Riemann integral, primitive functions, variable substitution, integration by parts, partial fractions. Riemann sums, geometric and other applications of integrals, improper integrals. Something about sequences and series. Something about numerical methods (eg Newton's method).",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 3", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 4", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 5", IsDone = false},
					}
				},
				new CourseEntity
				{
					Name = "SF1690 Basic Course in Mathematics",
					Description = "The trigonometric functions and their inverses, power, exponential and logarithmic functions, absolute value function, properties of functions, complex numbers, vectors, scalar and cross product, projections and linear combination.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 3", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 4", IsDone = false},
					}
				},
				new CourseEntity
				{
					Name = "ID1018 Programming",
					Description = "The course runs over a KTH period.",
					CourseAssignments = new List<CourseAssignmentEntity>
					{
						new CourseAssignmentEntity() { Name = "Assignment 1", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 2", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 3", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 4", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 5", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 6", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 7", IsDone = false},
						new CourseAssignmentEntity() { Name = "Assignment 8", IsDone = false},
					}
				},
			};

			// Intialize 5 teachers
			var teachers = new TeacherEntity[]
			{
				new TeacherEntity { Name = "Selena Gomes" },
				new TeacherEntity { Name = "Taylor Swift" },
				new TeacherEntity { Name = "Ariana Grande" },
				new TeacherEntity { Name = "Justin Bieber" },
				new TeacherEntity { Name = "Shakira Shakira" },
			};

			// Contect course to its teacher
			courses[0].Teacher = teachers[0];
			courses[1].Teacher = teachers[0];
			courses[2].Teacher = teachers[1];
			courses[3].Teacher = teachers[1];
			courses[4].Teacher = teachers[2];
			courses[5].Teacher = teachers[2];
			courses[6].Teacher = teachers[3];
			courses[7].Teacher = teachers[3];
			courses[8].Teacher = teachers[4];

			// Intialize student to coresponding courses
			var studentsToCourses = new StudentCourseEntity[]
			{
				new StudentCourseEntity { Student = students[0], Course = courses[0] },
				new StudentCourseEntity { Student = students[0], Course = courses[1] },
				new StudentCourseEntity { Student = students[0], Course = courses[2] },
				new StudentCourseEntity { Student = students[0], Course = courses[3] },
				new StudentCourseEntity { Student = students[0], Course = courses[4] },
				new StudentCourseEntity { Student = students[0], Course = courses[5] },
				new StudentCourseEntity { Student = students[0], Course = courses[6] },
				new StudentCourseEntity { Student = students[0], Course = courses[7] },

				new StudentCourseEntity { Student = students[1], Course = courses[0] },
				new StudentCourseEntity { Student = students[1], Course = courses[1] },
				new StudentCourseEntity { Student = students[1], Course = courses[2] },
				new StudentCourseEntity { Student = students[1], Course = courses[3] },
				new StudentCourseEntity { Student = students[1], Course = courses[4] },
				new StudentCourseEntity { Student = students[1], Course = courses[5] },

				new StudentCourseEntity { Student = students[2], Course = courses[0] },
				new StudentCourseEntity { Student = students[2], Course = courses[1] },
				new StudentCourseEntity { Student = students[2], Course = courses[2] },
				new StudentCourseEntity { Student = students[2], Course = courses[4] },

				new StudentCourseEntity { Student = students[3], Course = courses[3] },
				new StudentCourseEntity { Student = students[3], Course = courses[4] },
				new StudentCourseEntity { Student = students[3], Course = courses[5] },
				new StudentCourseEntity { Student = students[3], Course = courses[6] },

				new StudentCourseEntity { Student = students[4], Course = courses[5] },
				new StudentCourseEntity { Student = students[4], Course = courses[6] },
				new StudentCourseEntity { Student = students[4], Course = courses[7] },
				new StudentCourseEntity { Student = students[4], Course = courses[8] }
			};

			// Contect students to courses
			context.AddRange(studentsToCourses);
			context.SaveChanges();
		}
	}
}
