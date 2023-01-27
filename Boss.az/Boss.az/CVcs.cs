
namespace Boss.az
{
    enum Level { A1 = 1, A2, B1, B2, C1, C2 }

    class Language
    {
        public string Name { get; set; }
        public Level languageLevel { get; set; }

        public Language(string name, Level languageLevel)
        {
            Name = name;
            this.languageLevel = languageLevel;
        }

        public override string ToString() => $"{Name}=>{languageLevel}\n";
    }

    internal class CV
    {
        #region Properties

        public string? Profession { get; set; }

        public string? UniversityName { get; set; }

        public double UniversityScore { get; set; }

        public string[]? Skills { get; set; }

        public double Experience { get; set; }

        public string[]? Companies { get; set; }

        public bool DifferSertificate { get; set; }

        public string? Linkedin { get; set; }

        public string? Gitlink { get; set; }

        public List<Language>? Languages { get; }
        #endregion

        public CV(string? profession, string? universityName, double universityScore, string[]? skills, string[]? companies,
        bool differSertificate, string? linkedin, string? gitlink, List<Language>? languages, double experience)
        {
            Profession = profession;
            UniversityName = universityName;
            UniversityScore = universityScore;
            Skills = skills;
            Companies = companies;
            DifferSertificate = differSertificate;
            Linkedin = linkedin;
            Gitlink = gitlink;
            Languages = languages;
            Experience = experience;
        }

        //Create Cv

        public void Print()
        {
            Console.WriteLine($"**CV**\nProffesion:{Profession}\nUniversity:{UniversityName}\nUniversity Score:{UniversityScore}\nSpecial Certificste:{DifferSertificate}\n");

            Console.WriteLine("Skills:");
            foreach (var item in Skills)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Companies:");
            foreach (var item in Companies)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Languages:");
            foreach (var item in Languages)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"GitLink: {Gitlink}");
            Console.WriteLine($"Linkedin: {Linkedin}");
        }
    }
}