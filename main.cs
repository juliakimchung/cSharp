using System;

namespace Chapter1App
{

	class Chapter1
	{
		static void Main(string[] args)
		{
			int a = 10;
			double b = (double)a;
			Console.WriteLine(b.GetType());
			Console.WriteLine(b);

			const int i = 64;

			const double pi = 3.14159;

			Console.WriteLine(i);
			Console.WriteLine("I am a string!");

			double? score1 = null;
			double score2 = 67.5;
			double score3 = 88.2;
			double? avg = (score1 + score2 + score3)/ 3.0;

			Console.WriteLine(avg);

      string str = "Hola!";
      char first_char = str[0];
      Console.WriteLine(first_char);
      Console.WriteLine(str.Length);


      string str1 = "Hola!";
      string str2 = "Julia!";
      string str3 = str1 + " " +  str2;
      string str4 = String.Concat(str1, str2);
      Console.WriteLine(str3);
      Console.WriteLine(str4);

      char [] destarr = {'a', 'b', 'c', 'd', 'e'};
      string str5 = "fgh";
      str5.CopyTo(0, destarr, 0, str5.Length );
      Console.WriteLine(destarr);

      string findIndex = "test me!";
      int res =  findIndex.IndexOf('s');
      Console.WriteLine(res);


	  }
	}
}