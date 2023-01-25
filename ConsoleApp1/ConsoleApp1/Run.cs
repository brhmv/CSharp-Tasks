namespace System
{
    internal class Run
    {
        public void runFunc(Func del, string? str) => del.Invoke(str);
    }
}
