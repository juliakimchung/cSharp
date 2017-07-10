using System;
using System.IO;

namespace Chapter8App
{
	class Chapter8
	{
		static void Main(string[] args)
		{
			FileStream fs = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.Write);
			Console.WriteLine("Input text to be saved to the files: ");
			string input = Console.ReadLine();
			for(int i = 0; i < input.Length; i++)
			{
				fs.WriteByte((byte)input[i]);
			}
			fs.Close();

		}
	}
}