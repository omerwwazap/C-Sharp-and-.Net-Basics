using System;

namespace Q1
{
	class Program
	{
		static void Main(string[] args)
		{
			StudentCollection studentCollection = new StudentCollection();
			StudentCollection.QueryHighScores(1, 90);
			studentCollection[1, 2] = 80;
			Console.WriteLine("Student exam grade "+ studentCollection[1, 2]);

			studentCollection[0]++;

		}
	}
}
