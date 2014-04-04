using System;

namespace w5_while
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string word = "";
			do {
				Console.Write ("Enter a word: ");
				word = Console.ReadLine ();

				if (word == "q") {
					break;
				}
				Console.WriteLine (word);
			} while (true);

			Console.WriteLine("Bye!");
		}
	}
}
