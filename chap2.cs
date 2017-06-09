using System;

namespace Chap2App
{

	
	class Chap2
	{
		static void Main(string[] args)
		{
			//+
			int a = 5;
			int b = 3;
			int c = a+b;
			Console.WriteLine(c);
			//-
			int d = 22 - 13;
			int e = d -3;
			Console.WriteLine(e);
			//*
			Console.WriteLine(8*9);
			// /
			int f = 5;
			int g = 66;
			int h = 45;
			Console.WriteLine(f % 2);
			Console.WriteLine(10/3.0);
			Console.WriteLine(g++);
			Console.WriteLine(--h);
			Console.WriteLine(g--);
			Console.WriteLine(h);
			Console.WriteLine(g);

			int i = 274;
			int j = 273;
			string str1 = "hello";
			string str2 = "hello";
			string str3 = "274";
			Console.WriteLine(i < j);
			Console.WriteLine(str1 == str2);
			Console.WriteLine(i.ToString() == str3);


			bool t1 = true;
			bool f1 = false;
			Console.WriteLine(f1 || t1);


			int k = 50;
			int l = 33;
			int m = k & l ;
			Console.WriteLine(m);


			char n = 'b';
			if(n == 'b')
			{
					Console.WriteLine("This is true");			

			}
			else
			{
				Console.WriteLine("This is false");
			}

			int o = 200;
			if((o % 2 == 0 && o != 0) && (i > 100))
			{
				Console.WriteLine("even");
			}
			else if ( o == 0)
			{
				Console.WriteLine("zero");
		  }
		  else
		  {
		  	Console.WriteLine("odd");
		  }

		  string greeting = "Annyung!";

		  switch(greeting)
		  {
		  	case "Hola!":
		  		Console.WriteLine("Spanish");
		  		break;
		  	case "Hello!":
		  	 	Console.WriteLine("English");
		  	 	break;
		  	case "Bonjour!":
		  		Console.WriteLine("French");
		  		break;
		  	default:
		  		Console.WriteLine("Language not recognized");
		 			break;
			} 


		}

	}
}