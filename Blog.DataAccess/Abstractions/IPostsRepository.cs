using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.DataAccess.Abstractions
{
    public interface IPostsRepository
    {
        Task<Post> GetPostAsync(int postId);
        Task<List<Post>> GetPostsForAuthorAsync(int authorId);
        Task<bool> AddPostAsync(Post post);
        Task<bool> DeletePostAsync(int postId);
    }
}