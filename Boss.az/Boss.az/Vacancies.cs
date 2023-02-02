namespace Boss.az
{
    enum Worktype { Fulltime = 1, Parttime, Freelance, Remoute, Outsource }

    internal class Vacancy
    {

        #region Properties
        public string? Name { get; }

        public double Salary { get; }

        public double MinExperience { get; }

        public double MaxAge { get; }

        public Worktype workType { get; }
        #endregion

        public Vacancy(string name, double salary, double minExperience, double maxAge, Worktype wt)
        {
            Name = name;
            Salary = salary;
            MinExperience = minExperience;
            MaxAge = maxAge;
            workType = wt;
        }

        public static Vacancy createVacancy()
        {
            while (true)
            {
                try
                {
                    string? name;
                    double salary, minExperience, maxAge;
                    Worktype wt;

                    Console.Write("Insert name: ");
                    name = Console.ReadLine();

                    Console.Write("Insert salary:");
                    salary = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Insert minimum experience:");
                    minExperience = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Insert maximum age:");
                    maxAge = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Insert worktype 1)Fulltime 2)Part-time 3)Freelance 4)Remoute 5)Outsource: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            wt = Worktype.Fulltime;
                            break;
                        case 2:
                            wt = Worktype.Parttime;
                            break;
                        case 3:
                            wt = Worktype.Freelance;
                            break;
                        case 4:
                            wt = Worktype.Remoute;
                            break;
                        case 5:
                            wt = Worktype.Outsource;
                            break;
                        default:
                            continue;
                    }                

                    return new Vacancy(name, salary, minExperience, maxAge, wt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    continue;
                }

            }
        }

        public override string ToString() => $"Job: {Name} Salary: {Salary} Minimum Experience: {MinExperience} Maximum Age: {MaxAge} Work type: {workType}";

    }
}
