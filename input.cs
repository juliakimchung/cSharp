using System;

namespace Chapter8App
{

	class Chapter8
	{
		public static int Sum(int a, int b)
		{
			return a + b;
		}
		static void Main(string[] args)
		{
			int n1, n2, sum;
			Console.Write("Input first integer: ");
			n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input second integer: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			sum = Sum(n1, n2);
			Console.WriteLine("The sum is : {0}", sum);
		}
	}
}