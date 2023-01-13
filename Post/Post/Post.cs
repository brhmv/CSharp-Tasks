namespace PostNamespace

{
    internal class Post
    {
        public static int ID { get; set; }
        public int ObjectId { get; set; }

        public string? Content { get; set; }
        public DateTime date { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }

        public Post(string? content)
        {
            ObjectId = ID++;
            date = DateTime.Now;
            Content = content;
            LikeCount = 0;
            ViewCount = 0;
        }

        public override string ToString()=> $"Id:{ObjectId}\nContent:{Content}\nDate:{date}\nLikeCount:{LikeCount}\nViewCount:{ViewCount}\n";
       
    }
}
