using System.Reflection.Emit;
using UserNamespace;
using PostNamespace;
using AdminNamespace;

Admin admin = new("hakuna", "matata", "kamil");

Post post1 = new("Hello Earth :) ");
Post post2 = new("Hello Mars :) ");

admin.AddPost(post1);
admin.AddPost(post2);


User user1 = new("Azad", "Azadov", 42, "azad@gmail.com", "1234");
User user2 = new("Ali", "Alizade", 32, "ali@gmail.com", "4321");
User user3 = new("Aga", "Alizade", 12, "aga", "1111");

List<User> users = new();

users.Add(user1);
users.Add(user2);
users.Add(user3);

////////////////////////////////////////////////////////////////////////

string? choice;
label:

Console.WriteLine("1)User 2)Admin");
choice = Console.ReadLine();

if (choice == "1")
{
    string? email, password;
    Console.WriteLine("Insert email:");
    email = Console.ReadLine();

    Console.WriteLine("Insert password:");
    password = Console.ReadLine();
    bool correct = false;
    foreach (User item in users)
    {
        if (item.Email == email && item.Password == password)
        {
            Console.WriteLine("Signed in succesfully");
            correct = true;
            Thread.Sleep(2000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            admin.ShowPosts();
            Console.ForegroundColor = ConsoleColor.White;
        label2:
            string? choice2;
            Console.WriteLine("1)like  2)Notification 3)back ?");
            choice2 = Console.ReadLine();

            if (choice2 == "1")
            {
                int id;
                Console.WriteLine("Insert Id: ");
                id = Convert.ToInt32(Console.ReadLine());
                admin.LikePostByValue(id);

                Console.WriteLine("Liked Succesfuly");
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                admin.ShowPosts();
                Console.ForegroundColor = ConsoleColor.White;

                goto label2;
            }

            else if (choice2 == "2")
            {
                int id;
                Console.WriteLine("Insert ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                string? text;
                Console.WriteLine("Insert text: ");
                text = Console.ReadLine();

                admin.AddNotification(id, text, item);
                Console.WriteLine("Notification sent Succesfuly");
                Console.Clear();

                string? c;
                Console.WriteLine("1)Admin 2)Quit");
                c = Console.ReadLine();
                if (c == "1") goto label;
                else if (c == "2") break;
            }

            else if (choice2 == "3") goto label;
        }


    }

    if (!correct)
    {
        goto label;
    }
}


else if (choice == "2")
{
    string? name, password;

    Console.WriteLine("Insert username: ");
    name = Console.ReadLine();

    Console.WriteLine("Insert password: ");
    password = Console.ReadLine();

    if (name == "hakuna" && password == "matata")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Welcome admin :) ");
        label3:
        Console.WriteLine("1)Show all posts\n2)Show All Notifications\n3)Add Post\n4)Back");
        Console.ForegroundColor = ConsoleColor.White;

        string? choice3;
        choice3 = Console.ReadLine();

        if (choice3 == "1")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            admin.ShowPosts();
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("1)Back 2)Finish");
            string? c;
            c = Console.ReadLine();
            if (c == "1") goto label3;
            else if (c == "2") Console.WriteLine("Goodbye:)");
        }

        else if (choice3 == "2")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            admin.ShowNotifications();
            Console.ForegroundColor = ConsoleColor.White;
            string? c;
            c = Console.ReadLine();
            if (c == "1") goto label3;
            else if (c == "2") Console.WriteLine("Goodbye:)");
        }

        else if(choice3=="3"){
            string? text;
            text= Console.ReadLine();

            Post post=new(text);
            admin.AddPost(post);
            
            Console.WriteLine("Aded succesfully");

            string? c;
            c = Console.ReadLine();
            if (c == "1") goto label3;
            else if (c == "2") Console.WriteLine("Goodbye:)");
        }

        else if (choice3 == "4") goto label;
    }
    else goto label;
}

else
{
    Console.WriteLine("Choose one of them:");
    Console.Clear();
    goto label;
}