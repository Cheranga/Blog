namespace Blog.Api.DataAccess.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}