using System;

namespace Chapter6App

{
	class Vehicle
	{
		internal string VIN;
		internal int numberOfWheels;
		internal int numberOfDoors;
		internal string name;

		public void Drive()
		{
			Console.WriteLine("You are driving {0}", name);
		}

		public void setVIN(string v)
		{
			VIN = v;
		}

		public void setWheels(int w)
		{
			numberOfWheels = w;
		}
		public void setDoors(int d)
		{
			numberOfDoors = d;
		}
		public void setName(string n)
		{
			name = n;
		}
	}

	class Car : Vehicle
	{
		public void getDesc()
		{
			Console.WriteLine("VIN {0}", VIN);
			Console.WriteLine("Number of Doors {0}", numberOfDoors);
			Console.WriteLine("Number of Wheels {0}", numberOfWheels);
		}
	}
	class Chapter6
	{
		static void Main(string[] args)
		{
			var c = new Car();
			c.setName("Ferrari");
			c.setVIN("1234dnfkrgo");
			c.setDoors(2);
			c.setWheels(4);
			c.getDesc();
		}
	}
}