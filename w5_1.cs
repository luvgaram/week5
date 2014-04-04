using System;

namespace w5_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int loop = 0; loop < 5; loop++) {
				for (int star = 0; star <= loop; star++) {
					Console.Write ("*");
				}
				Console.WriteLine ("");
			}
		}
	}
}
