using System;

namespace Chapter4App
{
	class Chapter4
	{
		static void Main(string[] args)
		{
			int[] intarr = new int[10];//size, 0 -9
			intarr[0]= 32;
			intarr[3] = 56;

			//int[] numbers = new int[5] {1,3,5,4,9};
			int[] numbers = {1,3,5,7,9};
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			char[] chars = {'a','b','c','d'};
			foreach(char j in chars)
			{
				Console.WriteLine(j);
			}

			double[] numbers2 = new double[100];
			int jj = 1;
			for(int i = 0; i < numbers2.Length; i++)
			{
				if(jj % 3 ==0)
				{
					numbers2[i] += jj;
					Console.WriteLine(numbers2[i]);
				}
				jj++;
			}
			int assign = 0;
			int[ , ] mat = new Int32[2,3]; // new Int32[row, column];
			
			for(int i = 0; i < 2; i++)
			{
				for(int j = 0; j < 3; j++)
				{
					mat[i,j] += assign;
					assign += 2;
				}
			}

			string[][] heroes = new String [3][]{new string[]{"Bruce", " Wayne"}, new string[]{"Tony", " Stark"}, new string[]{"Captain", " Underpants"}};
			for(int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write(heroes[i][j]);
				}
				Console.Write('\n');
			}
		}
	}
}