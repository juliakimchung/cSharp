using System;

namespace Chapter5App
{
	class Brick
	{
		double mass = 2;
		double width = 2;
		double height = 2;

		public double Mass
		{
			get
			{
				return mass;
			}
			set
			{
				mass = value;
			}
		}
		public double Width
			{
				get
				{
					return width;
				}
				set
				{
					width = value;
				}
			}
		public double Height
		{
			get
			{
				return height;
			}
			set
			{
				height = value;
			}
		}

		public static Brick operator +(Brick a, Brick b)
		{
			var c = new Brick();
			c.Width = a.Width + b.Width;
			c.Height = a.Height + b.Height;
			c.Mass = a.Mass + b.Mass;
			return c;
		}
		public static Brick operator -(Brick a, Brick b)
		{
			var c = new Brick();
			c.Width = a.Width - b.Width;
			c.Height = a.Height - b.Height;
			c.Mass = a.Mass - b.Mass;
			return c;
		}

		
	}

	class Chapter5
	{
		static void Main(string[] args)
		{
			Brick wall = new Brick();
			Brick brick1 = new Brick();
			Brick brick2 = new Brick();
			Console.WriteLine("Mass: {0} Width: {1} Height: {2}", wall.Mass, wall.Width, wall.Height);
			wall = brick2 + brick1;
			Console.WriteLine("Mass: {0} Width: {1} Height: {2}", wall.Mass, wall.Width, wall.Height);
			wall = brick2 - brick1;
			Console.WriteLine("Mass: {0} Width: {1} Height: {2}", wall.Mass, wall.Width, wall.Height);
	}
	}     
}