
namespace Boss.az
{
    internal class Employer : Person
    {
        public List<Vacancy> Vacancies { get; set; }

        public Employer(string name, string surname, int age, string phone, string city, List<Vacancy> vacancies) : base(name, surname, age, phone, city)
        {
            Vacancies = vacancies;
        }

        //Add Employer

        //add Vacancy

        public void Print()
        {
            Console.WriteLine(base.ToString());

            foreach (var v in Vacancies) { Console.WriteLine(v); }
        }
    }
}