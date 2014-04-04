using System;

namespace w5_foreach
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("[foreach]");
			string word = "Programming";
			foreach (char character in word) {
				Console.WriteLine (character);
			}
			Console.WriteLine (); // foreach

			Console.WriteLine ("[for]");
			for (int loop = 0; loop < word.Length; loop++) {
				Console.WriteLine (word [loop]);
			}
			Console.WriteLine (); // for

			Console.WriteLine ("[array+for]");
			char[] word1 = new char[] {
				'P', 'r', 'o', 'g', 'a', 'm', 'm', 'i', 'n', 'g'
			};
			for (int loop = 0; loop < word1.Length; loop++) {
				Console.WriteLine (word1 [loop]);
			
			} // original array + for
		}
	}
}
