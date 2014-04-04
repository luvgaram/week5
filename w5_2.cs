using System;

namespace w5_2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int front = 1; front <= 9; front++) {
				if (front == 1) {
					Console.WriteLine ("[{0} time table]", front);
				} else {
					Console.WriteLine ("[{0} times table]", front);
				} // title
				for (int back = 1; back <= 9; back++) {
					Console.WriteLine ("{0} * {1} = {2}", front, back, front * back);
				}
				Console.WriteLine ();
			}
		}
	}
}
