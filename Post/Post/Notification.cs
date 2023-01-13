using UserNamespace;

namespace NotificationNamespace
{
    internal class Notification
    {       
        public static int Id = 0;
        public int ObjectID { get; set; }
        
        public string Text { get; set; }
        public DateTime date { get; set; }
        public User fromUser { get; set; }

        public Notification(string text, User fromUser)
        {
            ObjectID = Id++;
            Text = text;
            date = DateTime.Now;
            this.fromUser = fromUser;
        }

        public override string ToString()=>$"ID:{ObjectID}\nText:{Text}\nDate:{date}\nUser:{fromUser.Name}\n";
    }
}
