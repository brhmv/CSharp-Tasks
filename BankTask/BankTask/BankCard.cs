using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask
{
    internal class BankCard
    {
        public string BankName { get; set; }

        public string FullName { get; set; }

        public string Pan { get; set; }

        public string Pin { get; set; }

        public Decimal Balance { get; set; }

        public DateTime date;

        static public Random rand = new Random();


        private int cvc;
        public int Cvc { get => cvc; set => cvc = rand.Next(100, 999); }

        public BankCard(string Bankname, string fullName, string pan, string pin, Decimal balance)
        {
            date = DateTime.Now;
            BankName = Bankname;
            FullName = fullName;
            Pan = pan;
            Pin = pin;
            Balance = balance;
        }

        public void DecreaseBalance(decimal money)
        {
            if (Balance >= money)
            {
                Balance -= money;
            }

            else throw new Exception("Balance isn't enough");
        }

        public void IncreaseBalance(decimal money)
        {
            Balance += money;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{money}AZN Added to card");
            Console.ForegroundColor = ConsoleColor.White;
        }



        public override string ToString() => $"BankName: {BankName}\nFullName: {FullName}\nPAN: {Pan}\nPIN: {Pin}\nBalance: {Balance}\nExperied Date:{date}";
    }
}