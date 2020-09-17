using System;

namespace beer
{
	public class Program
	{
		public static void Main()
		{
			for (int i = 98; i >= 2; i--)
			{
				Console.WriteLine((++i) + " bottles of beer on the wall, " + (i) + " bottles of beer.");
				Console.WriteLine("Take one down and pass it around, " + (--i) + " bottles of beer.");
				Console.WriteLine((i) + " bottles of beer on the wall, " + (i) + " bottles of beer.");
				Console.WriteLine("Take one down and pass it around, " + (--i) + " bottle of beer.");
				Console.WriteLine((+i) + " bottle of beer on the wall, " + (+i) + " bottle of beer.");
				Console.WriteLine("Take one down and pass it around, " + (--i) + " bottle of beer.");
			}
		}
	}
}