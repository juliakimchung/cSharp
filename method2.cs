using System;

namespace Chapter5App
{
	class Chapter5
	{
		public int CalcSum(int a, int b)
		{
			return a + b;
		}
		public string Hello(string reply)
		{
			if(reply == "hi" || reply == "Hello")
			{
				return "How are you?";
			}
			else if(reply == "Go away!")
			{
				return "Fine, And you?";
			}
			else
			{
				return "I guess you don't want to work....";
			}
		}
		public double CalGPA(char[] grades)
		{
			double sum = 0;
			double count = grades.Length;
			double gpa = 0;

			foreach(char i  in grades)
			{
				switch(i)
				{
					case 'A':
						sum += 4;
						break;
					case 'B':
						sum += 3;
						break;
					case 'C':
						sum += 2;
						break;
					case 'D':
						sum += 1;
						break;
					default:
						sum += 0;
						break;

				}
			}
			gpa = sum / count;
			return gpa;
		}
		static void Main(string[] args)
		{
			var c = new Chapter5();
			string talk = "Go away!";
			string res = c.Hello(talk);
			int sum = c.CalcSum(8, 6);

			char[] grades = {'A', 'A', 'B', 'B', 'C'};
			double result = c.CalGPA(grades);
			Console.WriteLine(res);
			Console.WriteLine(sum);
			Console.WriteLine(result);
		}
	}
}