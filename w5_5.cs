using System;

namespace w5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sausage\tBun\tKetchup\tMustard\tOnions");
            for (int Sausage = 0; Sausage < 2; Sausage++)
            {
                for (int Bun = 0; Bun < 2; Bun++)
                {
                    for (int Ketchup = 0; Ketchup < 2; Ketchup++)
                    {
                        for (int Mustard = 0; Mustard < 2; Mustard++)
                        {  
                            for (int Onions = 0; Onions < 2; Onions++)
                            {
                                Console.Write("{0} \t {1} \t {2} \t {3} \t {4}", Sausage, Bun, Ketchup, Mustard, Onions);
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
