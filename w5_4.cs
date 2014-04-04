using System;

namespace w5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operator;
            int firstNum;
            int secondNum;
            int resultNumber;
            while (true)
            {
                Console.Write("Enter the operation[+,-,*,/](If you want to quit, enter 'q'): ");
                Operator = Console.ReadLine();
                if(Operator=="q"){
                    Console.Write("Bye!");
                    break;
                }
                else if ((Operator == "+") || (Operator == "-") || (Operator == "*") || (Operator == "/"))
                {
                    Console.Write("Enter the first number: ");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    secondNum = int.Parse(Console.ReadLine());
                    if (Operator == "+")
                    {
                        resultNumber = firstNum + secondNum;
                    }
                    else if (Operator == "-")
                    {
                        resultNumber = firstNum - secondNum;
                    }
                    else if (Operator == "*")
                    {
                        resultNumber = firstNum * secondNum;
                    }
                    else
                    {
                        resultNumber = firstNum / secondNum;
                    } Console.WriteLine("Result : {0}", resultNumber);
                }
                else
                {
                    Console.WriteLine("You entered wrong operation. Only +,-,*,/,q are allowed!");
                }
            }  
        }
    }
}
