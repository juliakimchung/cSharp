using System;

namespace Chap6App
{
	interface CarBase
	{
		void Drive();
	}
	struct Car : CarBase
	{
		public string make;
		public string model;
		public int year;
		public int doors;
		public int seats;
		public int hp;
		public double speed;

		public Car(string a, string b, int c, int d, int e, int f)
		{
			make = a;
			model = b;
			year = c;
			hp = d;
			doors = e;
			seats = f;
			speed = 0;
			Console.WriteLine("{0} {1} {2} was assembled", year, make, model);
		}

		public static Car operator++(Car a)
		{
			Car car = new Car();
			car.make = a.make;
			car.model = a.model;
			car.year = a.year;
			car.doors = a.doors;
			car.seats = a.seats;
			car.speed = a.speed + 10.0;
			Console.WriteLine("Speed increased by 10!");

			return car;
		}

		public void Drive()
		{
			Console.WriteLine("Vroom Vroom!");
		}
	}
	class Chap6
	{

		static void Main(string[] args)
		{
			Car Mini = new Car("Mini", "Cooper", 2004, 120, 2, 4);
			Mini.Drive();
			Console.WriteLine(Mini++);
			Console.WriteLine(Mini.speed);
			Mini++;
			Console.WriteLine(Mini++);
			Console.WriteLine(Mini.speed);


		}
	}
}