using System;

namespace Chapter4App
{
	class Chapter4
	{
		public void Overload()
		{
			Console.WriteLine("This is the original Overload method");
		}

		public void Overload(int a)
		{
			Console.WriteLine("This is the Overload method with an in arg = {0}", a);
		}

		public void Overload(double b)
		{
			Console.WriteLine("This is the Overload method with an double arg = {0}", b);
		}

		public string Overload(string s)
		{
			Console.WriteLine("This is the Overload method that returns a string = {0} ", s);
			return s;
		}


		static void Main(string[] args)
		{
			var c = new Chapter4();
			c.Overload();
			c.Overload(133575);
			c.Overload(3.14);
			c.Overload("Is this the string from Overlaod?");
			c.Overload("help is on the way!");
			string ss = c.Overload("help");
			Console.WriteLine(ss);

		}
	}
}