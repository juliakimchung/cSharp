using System;

namespace Chapter5App
{
	//<Access specifier> class classname{}
	class Car
	{
		//variables, always private inside class, default value is private
		private string make;
		private string model;
		private int year;

		public void setMake(string m)
		{
			make = m;
		}

		public void setModel(string mod)
		{
			model = mod;
		}

		public void setYear(int y)
		{
			year = y;
		}

		public string getDesc()
		{
			return year.ToString() + " "  + make + " " + model;
		}
	}


	class TestClass
	{
		public void Test()
		{
			Console.WriteLine("This is a test class!");
		}
	}

	class Chapter5
	{
		public int Cumulative(int start, int end)
		{
			int res = 0;
			for(int i = start; i<= end; i++)
			{
				res += i;
			}
			return res;
		}
		static void Main(string[] args)
		{
			object o = new TestClass();
			Console.WriteLine(o);

			int a = 2;
			int b = 16; 
		  var c = new Chapter5();
			int sum = c.Cumulative(a, b);
			Console.WriteLine("Cumulative sum: {0}", sum);

			var t = new TestClass();
			t.Test();


			string car = " ";
			var merc  = new Car();
			merc.setMake("Mercedes-Benz");
			merc.setModel("S-63 AMG");
			merc.setYear(2016);

			car = merc.getDesc();
			Console.WriteLine("You are driving a " + car);


		}
	}
}