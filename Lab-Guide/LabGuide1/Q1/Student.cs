using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
	enum GradeLevel
	{
		FirstYear=1, SecondYear, ThirdYear, FourthYear
	};
	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Id { get; set; }
		public GradeLevel Year { get; set; }

		public List<int> ExamScores;

		public override string ToString() => "\nId: " + Id + "\nFirstName: " + FirstName
				+ "\nLastName: " + LastName
				+ "\nExam scores: " + string.Join(",", ExamScores) +
				"\nExam average: "+ExamScores.Average();

		public static Student operator ++(Student stu)
		{
			Console.WriteLine("\nAverage of the student: "+stu.ExamScores.Average());
			return stu;
		}
	}

}
