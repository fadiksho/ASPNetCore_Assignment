using ASPNETCore_Assignments.Model;

namespace ASPNETCore_Assignments_Test.Utility
{
	public class CompareClasses
	{
		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="course1"></param>
		/// <param name="course2"></param>
		/// <returns></returns>
		public static bool IsCoursesEqual(Course course1, Course course2)
		{
			if (course1 == null || course2 == null)
			{
				return false;
			}

			if (course1.Id != course2.Id || course1.Name != course2.Name || course1.Description != course2.Description)
			{
				return false;
			}

			return true;
		}
		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="courseAssignment1"></param>
		/// <param name="courseAssignment2"></param>
		/// <returns></returns>
		public static bool IsCourseAssignmentEqual(CourseAssignment courseAssignment1, CourseAssignment courseAssignment2)
		{
			if (courseAssignment1 == null || courseAssignment2 == null)
			{
				return false;
			}

			if (courseAssignment1.Id != courseAssignment2.Id || courseAssignment1.Name != courseAssignment2.Name
				|| courseAssignment1.IsDone != courseAssignment2.IsDone)
			{
				return false;
			}

			return true;
		}
		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="teacher1"></param>
		/// <param name="teacher2"></param>
		/// <returns></returns>
		public static bool IsTeachersEqual(Teacher teacher1, Teacher teacher2)
		{
			if (teacher1 == null || teacher2 == null)
			{
				return false;
			}

			if (teacher1.Id != teacher2.Id || teacher1.Name != teacher2.Name)
			{
				return false;
			}

			return true;
		}
		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="student1"></param>
		/// <param name="student2"></param>
		/// <returns></returns>
		public static bool IsStudentsEqual(Student student1, Student student2)
		{
			if (student1 == null || student2 == null)
			{
				return false;
			}

			if (student1.Id != student2.Id || student1.Name != student2.Name)
			{
				return false;
			}

			return true;
		}
	}
}
