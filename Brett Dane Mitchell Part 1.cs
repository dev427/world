using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Assignment
{

	public class Program
	{
		public static void Main(string[] args)
		{
			string s = "Is it crazy how saying sentences backwards creates backwards sentences saying how crazy it is?";
			Console.WriteLine("Part 1");
			Console.WriteLine(" ");
			Console.WriteLine("Is it crazy how saying sentences backwards creates backwards sentences saying how crazy it is?");
			Console.Write(Reverse(s));
		}

		public static string Reverse(string s)
		{
			var result = new string(s.ToCharArray().Reverse().ToArray());
			return result;
		}
      
	}
}