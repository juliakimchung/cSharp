using System;

namespace Chapter6App

{

	interface Blueprint 
	{
		void Build();
		double getArea();
		void setHeight(double h);
		void setName(string s);
		void setFloors(int i);
	}

	class Building : Blueprint
	{
		double height;
		double width;
		int floors;
		string name;

		public void setHeight(double h)
		{
			height = h;
		}

		public void setName(string s)
		{
			name = s;
		}

		public void setFloors(int i)
		{
			floors = i;
		}
		public void setWidth(double w)
		{
			width = w;
		}

		public double getArea()
		{
			return width * height;
		}

		public void Build()
		{
			Console.WriteLine("The building called {0} has been built. It has {1} floors", name, floors);
		}


	}
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

			var b = new Building();
			double h = 500;
			double w = 355.5;
			int f = 20;
			b.setWidth(w);
			b.setHeight(h);
			b.setFloors(f);
			b.setName("Lexcorp");
			b.Build();
			Console.WriteLine("These are of the building : {0}", b.getArea());
		}
	}
}