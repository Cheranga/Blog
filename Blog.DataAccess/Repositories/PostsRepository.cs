using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.DataAccess.Abstractions;

namespace Blog.DataAccess.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly DatabaseConfig _config;

        public PostsRepository(DatabaseConfig config)
        {
            _config = config;
        }

        public Task<Post> GetPostAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPostsForAuthorAsync(int authorId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddPostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(int postId)
        {
            throw new NotImplementedException();
        }
    }
}