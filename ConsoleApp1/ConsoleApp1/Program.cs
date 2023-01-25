public delegate void Func(string s);

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string");

        var str = Console.ReadLine();
        
        MyClass? cls = new(str);
        
        Func funcDell = new(MyClass.Reverse);
        funcDell += MyClass.Space;
        
        Run run = new();
        run.runFunc(funcDell, str); 
    }
}