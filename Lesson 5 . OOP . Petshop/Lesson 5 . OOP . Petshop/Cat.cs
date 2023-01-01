namespace CatSpace
{
    internal class Cat
    {
        #region fields
        private string? nickname;
        private int age;
        private double price;
        private string? gender;
        private double mealQuantity;
        private int energy;
        #endregion

        Cat() { }

        public Cat(string? nickname, int age, double price, string? gender, double mealQuantity, int energy)
        {
            Nickname = nickname;
            Age = age;
            Price = price;
            Gender = gender;
            MealQuantity = mealQuantity;
            Energy = energy;
        }


        #region properities
        public string? Nickname { get => nickname; set => nickname = value; }

        public int Age { get => age; set => age = value; }

        public double Price { get => price; set => price = value; }

        public string? Gender { get => gender; set => gender = value; }

        public double MealQuantity { get => mealQuantity; set => mealQuantity = value; }

        public int Energy { get => energy; set => energy = value; }
        #endregion


        public void Eat()
        {
            price++;
            energy++;
        }

        public void Sleep() => energy++;

        public void Play() => energy--;

        public void isEnergyIsZero()
        {
            if (Energy == 0) Sleep();
        }

        public override string ToString()
        {
            return $"Nickname  {Nickname}  \nAge: {Age}  \nGender: {Gender} \nPrice: {Price} \nMealQuantity {MealQuantity} \nEnergy: {Energy}\n";
        }
    }
}
