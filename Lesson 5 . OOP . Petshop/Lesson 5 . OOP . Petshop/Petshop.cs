using CatHouse1;


namespace CatHouses
{
    internal class PetShop
    {
        public List<CatHouse> catHouses = new();

        public int CatHouseCount() { return catHouses.Count(); }

        PetShop() { }
    }
}
