using System;
namespace Chapter4App
{
	class Chapter4
	{
		static int Recursive(int num, ref int counter)
		{
			counter++;
			if(num >= 10)
			{
				return num;
			}
			return Recursive(num+ 1, ref counter);
		}

		static int recursiveTest(int remaining)
		{
				if(remaining <10)
			{
				return remaining;
			}
			return recursiveTest(remaining - 1);
		}
		static void Main(string[] args)
		{
			int count = 0;
			int total = Recursive(0, ref count);
			Console.WriteLine(total);
			Console.WriteLine(count);
			int res = recursiveTest(4);
			Console.WriteLine(res);
		}
	}
}