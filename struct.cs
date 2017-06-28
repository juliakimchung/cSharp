using System;

namespace Chapter6App
{
	public struct Cars
	{
		public string make;
		public string model;
		public int year;
		public int hp;
		public int doors;
		public int seats;

		public void AssemblyCar(string a, string b, int c, int d, int e, int f)
		{
			make = a;
			model = b;
			year = c;
			hp = d;
			doors = e;
			seats = f;
			Console.WriteLine("{0} {1} {2} was assembled", year, make, model);
		}

	}

	class Chapter6
	{
		static void Main(string[] args)
		{
			Cars Ferrari = new Cars();
			Ferrari.make = "Ferrari";
			Ferrari.model = "F-430";
			Ferrari.year = 2004;
			Ferrari.hp = 350;
			Ferrari.seats = 2;
			Ferrari.doors = 2;

			Console.WriteLine("What a waste of money to buy a {0} {1} {2}", Ferrari.year, Ferrari.make, Ferrari.model);
			Console.WriteLine("Is so fast! It has {0} horsepower, {1} doors, {2} seats", Ferrari.hp, Ferrari.doors, Ferrari.seats);

			Cars Mini = new Cars();
			Mini.AssemblyCar("Mini", "Cooper", 1992, 120, 2, 2);

			

		}

	}

}