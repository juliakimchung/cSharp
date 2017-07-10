using System;
using System.IO;

namespace Chapter8App
{
	class Chapter8
	{
		static void Main(string[] args)
		{
			// FileStream fs = new FileStream(string path, FileMode mode);
			FileStream fs = new FileStream("sample.txt", FileMode.Open, FileAccess.Read);
		  var length = fs.Length;
			fs.Position = 0;
			for (int i = 0; i < length; i++)
			{
				char output = (char)fs.ReadByte();
				Console.Write(output);
			}
			fs.Close();

		}
	}
}