using ASPNETCore_Assignments.Entity;
using ASPNETCore_Assignments.Model;

namespace ASPNETCore_Assignments_Test.Utility
{
	public class CompareClasses
	{
		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="model1"></param>
		/// <param name="model2"></param>
		/// <returns></returns>
		public static bool IsCoursesEqual(Course model1, Course model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.Id != model2.Id || model1.Name != model2.Name || model1.Description != model2.Description)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="model1"></param>
		/// <param name="model2"></param>
		/// <returns></returns>
		public static bool IsCourseAssignmentEqual(CourseAssignment model1, CourseAssignment model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.Id != model2.Id || model1.Name != model2.Name)
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
		public static bool IsTeachersEqual(Teacher model1, Teacher model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.Id != model2.Id || model1.Name != model2.Name)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="model1"></param>
		/// <param name="model2"></param>
		/// <returns></returns>
		public static bool IsStudentsEqual(Student model1, Student model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.Id != model2.Id || model1.Name != model2.Name)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="model1"></param>
		/// <param name="model2"></param>
		/// <returns></returns>
		public static bool IsCourseAssignmentEntityEqual(CourseAssignmentEntity model1, CourseAssignmentEntity model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.CourseId != model2.CourseId || model1.Name != model2.Name
				|| model1.Id != model2.Id)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="model1"></param>
		/// <param name="model2"></param>
		/// <returns></returns>
		public static bool IsTeacherEntitiesEqual(TeacherEntity model1, TeacherEntity model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.Id != model2.Id || model1.Name != model2.Name)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="model1"></param>
		/// <param name="model2"></param>
		/// <returns></returns>
		public static bool IsStudentEntitiesEqual(StudentEntity model1, StudentEntity model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.Id != model2.Id || model1.Name != model2.Name)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Compare only the value type of the object properties
		/// </summary>
		/// <param name="model1"></param>
		/// <param name="model2"></param>
		/// <returns></returns>
		public static bool IsCoursesEntityEqual(CourseEntity model1, CourseEntity model2)
		{
			if (IsModelsNull(model1, model2))
			{
				return false;
			}

			if (model1.Id != model2.Id|| model1.Name != model2.Name
				|| model1.Description != model2.Description || model1.TeacherId != model2.TeacherId)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Check if objects are null
		/// </summary>
		/// <param name="models">object to check for null</param>
		/// <returns>true if any is null</returns>
		public static bool IsModelsNull(params object[] models)
		{
			foreach(var model in models)
			{
				if (model == null) return true;
			}
			return false;
		}
	}
}