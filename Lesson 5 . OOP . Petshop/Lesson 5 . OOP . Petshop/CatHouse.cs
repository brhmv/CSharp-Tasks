using CatSpace;

namespace CatHouse1
{
    internal class CatHouse
    {
        public List<Cat> cats = new();

        public int catCount()
        {
            return cats.Count();
        }

        public void AddCat(Cat c)
        {
            cats.Add(c);
        }

        public void RemoveCat(string nickn)
        {
            foreach (Cat cat in cats)
            {
                if (cat.Nickname == nickn)
                {
                    cats.Remove(cat);
                }
            }
        }

        public void ShowCats()
        {
            foreach (Cat item in cats)
            {
                Console.WriteLine(item);
            }
        }
    }
}
