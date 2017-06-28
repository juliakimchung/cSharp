using System;

namespace Chapter6App
{
	class Chapter6
	{
		enum Months {Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Novv, Dec};
		
		static void Main(string[] args)
		{
			
			int first = (int)Months.Jan;
			Console.WriteLine(Months.Jan);
			Console.WriteLine(first);

		}
	}
}