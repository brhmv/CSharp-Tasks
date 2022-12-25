using System;
using System.Reflection.Emit;

namespace Calculator
{
    class Program
    {

        static void Plus(out double result, double num1, double num2)
        {
            result = num1 + num2;
        }
        
        static void Minus(out double result, double num1, double num2)
        {
            result = num1 - num2;
        }
        
        static void Divide(out double result, double num1, double num2)
        {
            result = num1 / num2;
        }
        
        static void Multiple(out double result, double num1, double num2)
        {
            result = num1 * num2;
        }

        static void Main()
        {
            int choice = default;

            Console.WriteLine("Insert number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

        Label:

            Console.WriteLine("\nInsert operation: ");
            ConsoleKeyInfo key = Console.ReadKey();


            Console.WriteLine("\nInsert number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = default;

            Console.Write("Result: ");
            switch (key.Key)
            {
                case 0:
                    break;
                case ConsoleKey.OemPlus:
                    Plus(out result, number1, number2);
                    Console.WriteLine(result);
                    break;
                case ConsoleKey.OemMinus:
                    Minus(out result, number1, number2);    
                    Console.WriteLine(result);
                    break;
                case ConsoleKey.D8:
                    Multiple(out result, number1, number2);
                    Console.WriteLine(result);
                    break;
                case ConsoleKey.Oem2:
                    Divide(out result, number1, number2);
                    Console.WriteLine(result);
                    break;
                default:
                    goto Label;
            }

            number1 = result;

            goto Label;

        }
    }
}
