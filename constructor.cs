using System;
namespace Chapter5App
{

	class AssemblyBot
	{
		private int id;
		public AssemblyBot(int i)
		{
			id = i;
			Console.WriteLine("I am AssemblyBot # {0}. I was just created!", i);
		}

	  ~AssemblyBot()
		{
			Console.WriteLine("I have gone out of scope! I must be determinated!");
		}
	}

	class  Chapter5
	{
		static void Main(string[] args)
		{
			int i = 3;
			var bot0 = new AssemblyBot(i);
			
		}
	}
}