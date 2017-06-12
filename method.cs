using System;

namespace Chaper5App
{
	class Chapter5
	{
	  static public int CalSum()
		{
			int a = 66;
			int b = 77;
			return a + b;

		}
	
		static void Main(string[] args)
		{
			// var c = new Chapter5();
			int sum = CalSum();
			Console.WriteLine(sum);
		}
	}
}