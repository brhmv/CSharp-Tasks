

namespace Boss.az
{
    internal class Worker : Person
    {

        public CV? CV { get; set; }

        public Worker(string name, string surname, string city, string phone, sbyte age, CV? cv = null)
            : base(name, surname, age, phone, city)
        {
            CV = cv;
        }


        //AddWorker

        public void Print()
        {
            Console.WriteLine(base.ToString);
            CV.Print();
        }
    }
}