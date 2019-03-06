namespace Blog.DataAccess
{
    public class Comment
    {
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public string Data { get; set; }
    }
}