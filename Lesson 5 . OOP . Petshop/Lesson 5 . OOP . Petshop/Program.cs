using CatSpace;
using CatHouse1;

Cat cat = new("A", 5, 4.5, "male", 12.3, 8);

Cat cat1 = new("B", 3, 3.5, "female", 3.3, 3);

cat1.Play();

cat.Play();

cat.Sleep();

cat.Eat();

CatHouse house = new();

house.AddCat(cat);

house.AddCat(cat1);

house.ShowCats();
