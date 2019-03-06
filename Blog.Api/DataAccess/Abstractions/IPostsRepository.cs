using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Api.DataAccess.Models;

namespace Blog.Api.DataAccess.Abstractions
{
    public interface IPostsRepository
    {
        Task<Post> GetPostAsync(int postId);
        Task<List<Post>> GetPostsForAuthorAsync(int authorId);
        Task<bool> AddPostAsync(Post post);
        Task<bool> DeletePostAsync(int postId);
    }
}