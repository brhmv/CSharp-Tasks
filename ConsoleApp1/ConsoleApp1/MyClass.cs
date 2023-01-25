
namespace System
{
    internal class MyClass
    {
        public string? Str { get; set; }

        public MyClass(string? str) => Str = str;


        static public void Reverse(string str)
        {
            for (int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        static public void Space(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + "_");
            }
            Console.WriteLine();
        }
    }
}