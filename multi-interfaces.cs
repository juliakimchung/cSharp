using System;

namespace Chapter5App
{
	interface Transport
	{
		void Go();
		void SetSpeed(double s);
		void Stop();

	}

	class Car
	{
		internal int VIN;
		internal string terrain;
		internal int numberWheels;
		internal int numberDoors;
		internal int seatCap;
		internal double speed;

		public void DriveFast()
		{
			Console.WriteLine("Flooring it! VROOOOMM");
		}

	}

	class Mercedes : Car, Transport
	{
		private string model;
		private string year;

		public void Go()
		{
			Console.WriteLine("The Light is green GO!");
		}

		public void SetSpeed(double s)
		{
			speed = s;
		}

		public void Stop()
		{
			speed = 0;
			Console.WriteLine("Red light! STOP!");
		}
	}

	class Chapter5
	{
		static void Main(string[] args)
		{
			var merc = new Mercedes();
			double s = 65;
			merc.Go();
			merc.SetSpeed(s);
			Console.WriteLine("Driving at {0} mph", merc.speed);
			merc.DriveFast();
			s = 160;
			merc.SetSpeed(s);
			Console.WriteLine("Driving at {0} mph ", merc.speed);
			merc.Stop();
			Console.WriteLine("Driving at {0} mph", merc.speed);

		}
	}
}