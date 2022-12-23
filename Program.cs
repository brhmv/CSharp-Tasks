using System;
using System.Reflection.Emit;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            int choice = default;

            Console.WriteLine("Insert number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

        Label:

            Console.WriteLine("\nInsert operation: ");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.OemPlus)
            {
                // Console.WriteLine("+");
                choice = 1;
            }
            else if (key.Key == ConsoleKey.Oem2)
            {
                // Console.WriteLine("/");
                choice = 4;
            }
            else if (key.Key == ConsoleKey.OemMinus)
            {
                choice = 2;
                // Console.WriteLine("-");
            }
            else if (key.Key == ConsoleKey.D8)
            {
                //  Console.WriteLine("*");
                choice = 3;
            }
            else
            {
                goto Label;
                Console.WriteLine(key.Key);
            }

            Console.WriteLine("\nInsert number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = default;

            Console.Write("Result: ");
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    result = number2 + number1;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine(result);
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine(result);
                    break;
                case 4:
                    result = number1 / number2;
                    Console.WriteLine(result);
                    break;
            }

            number1 = result;

            goto Label;

        }
    }
}