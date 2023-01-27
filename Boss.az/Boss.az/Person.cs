

namespace Boss.az
{
    internal class Person
    {
        #region Properties
        public Guid Id { get; }

        public string Name { get; set; }

        private string Name01;

        public string Name1
        {
            get { return Name01; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Name is not valid!");
                Name1 = value;
            }
        }



        public string Surname { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }
        #endregion

        public Person(string name, string surname, int age, string phone, string city)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
            City = city;
        }

        public override string ToString() => $"Id: {Id} {Name} {Surname} {Age} years old. From {City}. Phone: {Phone}\n";

    }
}