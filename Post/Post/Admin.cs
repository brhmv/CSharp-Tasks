using NotificationNamespace;
using PostNamespace;
using UserNamespace;

namespace AdminNamespace
{
    internal class Admin
    {

        //id,username,email,password,Posts,Notifications
        public static int ID { get; set; }
        public int ObjectId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public static List<Post> posts = new();
        public List<Notification> Notifications = new();


        public Admin(string username, string password, string email)
        {
            ObjectId = ID++;
            Username = username;
            Password = password;
            Email = email;
        }

        public override string ToString() => $"Id:{ObjectId}\nName:{Username}\nPassword:{Password}\nEmail:{Email}\n";


        public void AddPost(Post post) => posts.Add(post);


        public void ShowPosts()
        {
            foreach (var item in posts)
            {
                item.ViewCount++;
                Console.WriteLine(item);
            }
        }

        public void AddNotification(Notification n) => Notifications.Add(n);


        public void ShowNotifications()
        {
            foreach (var item in Notifications)
            {
                Console.WriteLine(item);
            }
        }

        public void LikePostByValue(int Id)
        {
            foreach (var item in posts)
            {
                if (item.ObjectId == Id)
                {
                    item.LikeCount++;
                    Console.WriteLine(item);
                }
            }
        }

        public void AddNotification(int ID, string text, User user)
        {
            foreach (var item in posts)
            {
                if (item.ObjectId == ID)
                {
                    Notification not = new(text, user);
                    Notifications.Add(not);
                }
            }
        }
    }
}
