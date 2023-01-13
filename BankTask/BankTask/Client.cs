using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask
{
    internal class Client
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string SurName { get; set; }

        public int Age { get; set; }
        
        public Double Salary { get; set; }
        
        public BankCard bankAccount { get; set; }

        public Client(int id, string name, string surName, int age, double salary, BankCard bankAccount)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Age = age;
            Salary = salary;
            this.bankAccount = bankAccount;
        }

        public override string ToString()=>$"Id: {Id} Name: {Name} Surname: {SurName} Age: {Age} Salary: {Salary} Account: {bankAccount}";
        
    }
}
