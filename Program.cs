
//Task:

//Konsolda 10 sualdan ibaret imtahan yazmaginiz teleb olunur. 

//1.  Proqramda statik olaraq 10 sual ve her sualin 3 cavabi olacaq. 

//2.  Her defe proqrami basladan zaman variantlarda olan cavablar random deyismelidir. Meselen:

//	Proqrami 1 - ci defe isedusen zaman sualin cavabi 
//	a) Baki
//    b) Gence
//    c) Naxcivan
//    Proqrami 2-ci defe isedusen zaman sualin cavabi
//	a) Gence
//    b) Naxcivan
//    c) Baki
//    Proqram bu qaydada her defe cavablari qarisdirmalidir.

//3.  Butun suallar ilk defeden acilmir bir suala cavab verennen sonra o biri sual acilir.

//4.  Istifadeci suala cavab vermek ucun sadece varianti secmelidir(Sualin cavabini konsolda yazmamalidir).

//5.Duzgun cavab verilende hemen sual yasil rengde olsun, sehv cavabda qirmizi rengde.

//6.  Her duzgun suala gore user 10 xal qazanir her verdiyi cavaba gore 10 xal cixilir. Xal eger menfi olursa o zaman 0 xal gostersin yeni menfi xal olmasin. Proqramin sonunda yazilsin ki, imtahan bitmisdir siz filan qeder xal toplamisiniz. 



using System;

namespace Quiz
{
    internal class Program
    {


        static void showAllOptions(string[] optns)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(optns[i]);
            }
        }

        static string[] Mix(string a, string b, string c)
        {
            string[] arr = { a, b, c };

            int oldPos;
            int newPos;

            for (int i = 0; i < 10; i++)
            {
                oldPos = Random.Shared.Next(0, 3);
                newPos = Random.Shared.Next(0, 3);

                string temp;

                temp = arr[oldPos];
                arr[oldPos] = arr[newPos];
                arr[newPos] = temp;
            }

            return arr;
        }


        private static void Main()
        {
            int totalScore = 0;

            string[,] s = new string[,]
            {
            {"Which one is reference type ?", "Struct", "Class", "Int", "Class" },
            { "Which one isn't cast operator ?", "Is a", "As a", "Has a", "Has a" },
            { "What is OOP ?", "Type", "Namespace", "Paradigma", "Paradigma" },
            { "Which one is un overloadable ?", "+=", "&", "&&", "&" },
            { "Property isn't consisted with :","Get","Set","Let","Let"}
            };

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome quiz, Good Luck :)");
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(1000);
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(s[i, 0]);
                Console.BackgroundColor = ConsoleColor.Black;

                showAllOptions(Mix(s[i, 1], s[i, 2], s[i, 3]));
                Console.WriteLine("**************");
                string uanswer = Console.ReadLine();

                if (uanswer == s[i, 4])
                {
                    Console.Clear();

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(s[i, 0]);
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Green;
                    showAllOptions(Mix(s[i, 1], s[i, 2], s[i, 3]));
                    Console.WriteLine($"You choosed {uanswer}");
                    Console.ForegroundColor = ConsoleColor.White;

                    totalScore += 10;

                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(s[i, 0]);
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Red;
                    showAllOptions(Mix(s[i, 1], s[i, 2], s[i, 3]));
                    Console.WriteLine($"You choosed {uanswer}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Your score is {totalScore} /50");
            Console.BackgroundColor = ConsoleColor.Black;


        }
    }
}