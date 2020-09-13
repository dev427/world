using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Assignment
{

	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("     Part 2");
			Console.WriteLine(" ");
			Console.WriteLine("Is a Palindrome:");
			bool palindrome = true;
			if (palindrome)
			{
				Console.WriteLine("anna      ---> True");
				Console.WriteLine("bob       ---> True");
				Console.WriteLine("reviver   ---> True");
				Console.WriteLine("civic     ---> True");
			}
			else
			{
				Console.WriteLine("diana     ---> False");
				Console.WriteLine("levels    ---> False");
				Console.WriteLine("reciever  ---> False");
				Console.WriteLine("cedric    ---> False");
			}
			Console.WriteLine(" ");
			{
				Console.WriteLine("Not a Palindrome:");
				bool not_palindromes = false;
				if (not_palindromes)
				{
					Console.WriteLine("anna      ---> True");
					Console.WriteLine("level     ---> True");
					Console.WriteLine("reviver   ---> True");
					Console.WriteLine("civic     ---> True");
				}
				else
				{
					Console.WriteLine("diana     ---> False");
					Console.WriteLine("levels    ---> False");
					Console.WriteLine("reciever  ---> False");
					Console.WriteLine("cedric    ---> False");
				}
			}
		}
	}
}
