using System;

namespace Assignment
{

	class Program
	{

		static void Main(string[] args)
		{

			string[] palindromes = new string[5];
			palindromes[0] = "anna    ---> true  |  diana   ---> false";
			palindromes[1] = "otto    ---> true  |  lotto   ---> false";
			palindromes[2] = "level   ---> true  |  levels  ---> false";
			palindromes[3] = "stats   ---> true  |  taste   ---> false";
			palindromes[4] = "rotator ---> true  |  rotate  ---> false";
			Console.WriteLine("     Part 1");
			Console.WriteLine("Backwards Text:");
			Console.WriteLine(" ");
			Console.WriteLine("Is it crazy how saying sentences backwards creates backwards sentences saying how crazy it is?");
			Console.WriteLine("⸮ƨi Ɉi γzɒɿɔ woʜ ϱniγɒƨ ƨɘɔnɘɈnɘƨ ƨbɿɒwʞɔɒd ƨɘɈɒɘɿɔ ƨbɿɒwʞɔɒd ƨɘɔnɘɈnɘƨ ϱniγɒƨ woʜ γzɒɿɔ Ɉi ƨI");
			Console.WriteLine(" ");
			Console.WriteLine("Madam I'm Adam   --->  mɒbA m'I mɒbɒM");
			Console.WriteLine("step on no pets  --->  ƨɈɘq on no qɘɈƨ");
			Console.WriteLine("top spot         --->  Ɉoqƨ qoɈ");
			Console.WriteLine("Sue us           --->  ƨυ ɘυƧ");
			Console.WriteLine(" ");
			Console.WriteLine("     Part 2");
			Console.WriteLine("Palindromes:");
			Console.WriteLine(" ");
			Console.WriteLine(palindromes[0]);
			Console.WriteLine(palindromes[1]);
			Console.WriteLine(palindromes[2]);
			Console.WriteLine(palindromes[3]);
			Console.WriteLine(palindromes[4]);
		}
	}
}