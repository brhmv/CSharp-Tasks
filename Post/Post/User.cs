namespace UserNamespace
{
    internal class User
    {
        
        public static int ID { get; set; }
        public int ObjectId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, string surname, int age, string email, string password)
        {
            ObjectId = ID++;
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = password;
        }

        public override string ToString()=> $"Id:{ObjectId}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nEmail:{Email}\nPassword:{Password}\n";
        
    }
}
