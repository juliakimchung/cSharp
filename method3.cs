using System;

namespace Chapter4App
{
	class Chapter4
	{
		public void changeData(ref int b)
		{
			b += 5;
		}

		public void PutWordsIntoMouth(out string words)
		{
			words = "Hey! That's pretty good!";
		}

		public void ReturnMultiple(out int a, out double b, out string c)
		{
			a = 36;
			b = 36.5;
			c = "Thirty-six";
		}

		static void Main(string[] args)
		{
			int a = 255;
			var c = new Chapter4();
			c.changeData(ref a);
			Console.WriteLine(a);

			string empty = "";
			var cc = new Chapter4();
			cc.PutWordsIntoMouth(out empty);
			Console.WriteLine(empty);

			int i = 0;
			double d = 0;
			string s = "";
			var ccc = new Chapter4();
			ccc.ReturnMultiple(out i, out d, out s);
			Console.WriteLine("Here are your results: {0},{1},{2}", i, d, s);
		}
	}
}