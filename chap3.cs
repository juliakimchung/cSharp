using System;

namespace  Chapter3App
{
	class Chapter3
	{
		static void Main(string[] args)
		{
			int counter = 0;
			while(counter < 10)
			{
				Console.WriteLine("Counter: {0}", counter);
				counter ++;
			}

			int counter2 = 0;
			char c = 'a';
			while(counter2 < 26)
			{
				Console.WriteLine(c);
				c++;
				counter2++;
			}

			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine("Sam");
			}

			int num = 1;
			do
			{
				if(num %3 == 0 && num % 2 !=0)
				Console.WriteLine(num);
				num++;
			}
			while(num <= 100 );

			char cc = 'a';

			while(cc <= 'z')
			{
				Console.WriteLine(cc + " ");
				if(cc == 'q')
				{
					Console.WriteLine("End reached at: {0}", cc);
					break;
				}
				cc++;
			}

			for(int i = 1; i <= 10; i++ )
			{
				for(int j = 1; j <= 10; j++)
				{
					if (i * j % 5 != 0)
					{
						continue;
					}
					Console.Write( i * j + " ");
				}
				Console.WriteLine();
			}
		}
	}
}