using System;

namespace Chapter5App
{
	class Vehicle
	{
		public virtual void Drive()
		{
			Console.WriteLine("You are driving a vehicle.");
		}
	}

	class Car: Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("You are driving a car!");
		}
	}

	class Truck: Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("You are driving a truck!");
		}
	}

	class Chapter5
	{
		static void Main(string[] args)
		{
			var v = new Vehicle();
			var c = new Car();
			var t = new Truck();

			v.Drive();
			c.Drive();
			t.Drive();
		}
	}
}