﻿using System;

namespace w5_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{

		
			Random random = new Random ();
			int number = random.Next (0, 100);
			Console.WriteLine ("AHOY! I'm the Dread Pirate Roberts, and I have a secret! It is a number from 1 to 99. I'll give you 6 tries.");
			Console.Write ("What's Your Guess? ");
			int guess = int.Parse (Console.ReadLine ());
			for (int loop = 0; loop < 6; ++loop) {
					if (guess!= number & loop == 5) {
						Console.WriteLine ("No more Guess! Better luck next time");
						break;
					} else if (guess == number) {
						Console.WriteLine ("You got it!!!");
						break;
					} else if (guess > number) {
						Console.WriteLine ("Too high!");
					} else if (guess < number) {
						Console.WriteLine ("Too low!");
					}

				Console.Write ("What's Your Guess? ");
				guess = int.Parse (Console.ReadLine ());
			}

		}
	}
}
