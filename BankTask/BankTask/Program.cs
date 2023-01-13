using BankTask;
using System.Reflection.Emit;

#region

BankCard c1 = new("Kapital", "KB", "0000000000000000", "0000", 100);
BankCard c2 = new("Kapital", "KB", "1111111111111111", "1111", 1200);
BankCard c3 = new("Kapital", "KB", "2222222222222222", "2222", 1020);
BankCard c4 = new("Kapital", "KB", "3333333333333333", "3333", 200);
BankCard c5 = new("Kapital", "KB", "4444444444444444", "4444", 540);

User u1 = new("Kamil", "a", c1);
User u2 = new("Azad", "b", c2);
User u3 = new("Akif", "c", c3);
User u4 = new("Aqil", "d", c4);
User u5 = new("Adil", "e", c5);

List<User> users = new();
users.Add(u1);
users.Add(u2);
users.Add(u3);
users.Add(u4);
users.Add(u5);
#endregion

Console.WriteLine("Insert pin: ");
string? pass;
pass = Console.ReadLine();

foreach (var item in users)
{
    if (item.card.Pin == pass)
    {
    label:
        Console.Clear();
        Console.WriteLine("1)Balance 2)Cash 3)Card to Card 4)Exit");
        string? choice;
        choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your Balance is:{item.card.Balance}\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1)Back 2)Exit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                goto label;
            }
            break;
        }

        else if (choice == "2")
        {
            int choice2;
        label2:
            Console.WriteLine($"Your Balance: {item.card.Balance}");
            Console.WriteLine("1)10 AZN\n2)20 AZN\n3)50 AZN\n4)100 AZN\n5)Else\n6)Back");
            choice2 = Convert.ToInt32(Console.ReadLine());

            switch (choice2)
            {
                case 1:
                    try
                    {
                        item.card.DecreaseBalance(10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("10 AZN converted to cash");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        goto label;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto label2;
                    }

                case 2:
                    try
                    {
                        item.card.DecreaseBalance(20);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("20 AZN converted to cash");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        goto label;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Thread.Sleep(2000);
                        goto label2;
                    }

                case 3:
                    try
                    {
                        item.card.DecreaseBalance(50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("50 AZN converted to cash");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        goto label;

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto label2;
                    }

                case 4:
                    try
                    {
                        item.card.DecreaseBalance(100);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("100 AZN converted to cash");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        goto label;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto label2;
                    }
                case 5:
                    Console.Clear();
                    decimal money;
                    Console.WriteLine("Insert Amount: ");
                    money = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        item.card.DecreaseBalance(money);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{money} AZN converted to cash");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        goto label;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto label2;
                    }
                case 6:
                    goto label;
                default:
                    Console.WriteLine("Choose one of them!");
                    goto label2;
            }
        }

        else if (choice == "3")
        {
            Console.Clear();
            string? pan;
            Console.WriteLine("Insert PAN:");
            pan = Console.ReadLine();

            bool Exist = false;
            Console.Clear();

            foreach (User i in users)
            {
                if (i.card.Pan == pan)
                {
                    Exist = true;
                    int amount;
                    Console.WriteLine($"Your Balance: {item.card.Balance}");
                    Console.WriteLine("Insert Amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        item.card.DecreaseBalance(amount);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto label;
                    }

                    i.card.IncreaseBalance(amount);

                    foreach (var q in users)
                    {
                        if (q.card.Pan == i.card.Pan)
                        {
                            users.Remove(q);
                            users.Add(i);
                            break;
                        }
                    }
                    Thread.Sleep(3000);
                    goto label;
                }
            }
            if (!Exist)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Card couldn't found!");
                Console.ForegroundColor = ConsoleColor.White;
                goto label;
            }
        }

        else if (choice == "4")
            break;
        break;
    }

}