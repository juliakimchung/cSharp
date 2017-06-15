using System;

namespace Chapter5App
{

	class Circle
	{
		static double radius;//static means only one variable
		public static double pi = 3.14;

		public void setRadius(double r)
		{
			radius = r;
		}
		public static double getCircumference()
		{
			return 2 * pi * radius; 
		}
	}

	class Triangle
	{
	  internal double bas;
	  internal double height;

		public void setBase(double d)
		{
			bas = d;
		}

		public void setHeight(double h)
		{
			height = h;
		}

		public double getBase()
		{
			return bas;
		}

		public double getHeight()
		{
			return height;
		}

		public double getArea()
		{
			return( bas * height)/2;
	  }
	}

	class Chapter5
	{
		static void Main(string[] args)//static means only one method
		{
			Triangle tri = new Triangle();
		  tri.setBase(20);
			tri.setHeight(25.5);
			double b = tri.getBase();
			double h = tri.getHeight();

			Console.WriteLine("The area of a triangle with the base {0} and height {1} = {2}", b, h, tri.getArea());
			double r = 2;
			var circ = new Circle();
			circ.setRadius(r);
			double circumference = Circle.getCircumference();
			Console.WriteLine(circumference);
		}
	}
}