using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask
{
    internal class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public BankCard card { get; set; }

        public User(string name,string surname,BankCard bankcard) {
            card = bankcard;
            name = name;
            name = surname;                    
        }
        public override string ToString() => $"Name:{name}\nSurname:{surname}\nBankCard{card.Pan}\n";    
    }
}