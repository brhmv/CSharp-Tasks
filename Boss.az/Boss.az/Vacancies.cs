
namespace Boss.az
{
    enum Worktype { Fulltime = 1, Parttime, Freelance, Remoute, Outsource }

    internal class Vacancy
    {

        public string? Name { get; }

        public double Salary { get; }

        public double MinExperience { get; }

        public double MaxAge { get; }

        public Worktype workType { get; }

        public Vacancy(string name, double salary, double minExperience, double maxAge, double workPeriod, Worktype wt)
        {
            Name = name;
            Salary = salary;
            MinExperience = minExperience;
            MaxAge = maxAge;
            workType = wt;
        }


        //add vacancy


        public override string ToString()=>$"Job: {Name} Salary: {Salary} Minimum Experience: {MinExperience} Maximum Age: {MaxAge} Work type: {workType}";
        

    }
}
