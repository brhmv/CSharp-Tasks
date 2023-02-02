namespace Boss.az
{
    internal class Employer : Person
    {

        public List<Vacancy> Vacancies { get; set; }

        public Employer(string name, string surname, int age, string phone, string city, List<Vacancy>? vacancies = null) : base(name, surname, age, phone, city)
        {
            Vacancies = vacancies;
        }

        public static Employer createEmployer()
        {
            while (true)
            {
                try
                {
                    string? name, surname, city, phone;
                    sbyte age;
                 
                    Console.Write("Insert your name: ");
                    name = Console.ReadLine();

                    Console.Write("Insert your Surname: ");
                    surname = Console.ReadLine();

                    Console.WriteLine("Insert your age:");
                    age = Convert.ToSByte(Console.ReadLine());

                    Console.Write("Insert your adress(City): ");
                    city = Console.ReadLine();

                    Console.Write("Insert your phone: ");
                    phone = Console.ReadLine();

                    return new(name, surname, age, phone, city);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    continue;
                }
            }
        }

        public void addVacancy(Vacancy vacancy) { Vacancies.Add(vacancy); }

        public void showVacancies()
        {
            foreach (var item in Vacancies)
            {
                Console.WriteLine(item);
            }
        }

        public void Print()
        {
            Console.WriteLine(base.ToString());

            foreach (var v in Vacancies) { Console.WriteLine(v); }
        }
    }
}
