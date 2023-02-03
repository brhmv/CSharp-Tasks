namespace Boss.az
{

    internal class Employer : Person
    {
        #region Properties
        public List<Notification> Notifications { get; set; }

        public List<Vacancy> Vacancies { get; set; }

        public Employer(string name, string surname, int age, string phone, string city) : base(name, surname, age, phone, city)
        {
            Vacancies = new();
            Notifications = new();
        }
        #endregion

        #region Accept/Reject Notification
        public void AcceptNotification(int id)
        {
            foreach (var item in Notifications)
            {
                if (item.ObjectId == id)
                {
                    item.AcceptedOrNot = true;
                    Console.WriteLine("Worker accepted!");
                    Thread.Sleep(200);
                    Notifications.Remove(item);
                }
            }
        }

        public void RejectNotification(int id)
        {
            foreach (var item in Notifications)
            {
                if (item.ObjectId == id)
                {
                    item.AcceptedOrNot = false;
                    Console.WriteLine("Worker rejected!");
                    Thread.Sleep(200);
                    Notifications.Remove(item);
                }
            }
        }
        #endregion

       

        public static Employer CreateEmployer()
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

        public void AddVacancy(Vacancy vacancy) { Vacancies.Add(vacancy); }

        public void ShowVacancies()
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
