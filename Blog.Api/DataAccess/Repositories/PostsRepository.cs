using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Blog.Api.DataAccess.Abstractions;
using Blog.Api.DataAccess.Models;
using Dapper;
using Microsoft.Extensions.Logging;

namespace Blog.Api.DataAccess.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly DatabaseConfig _config;
        private readonly ILogger<PostsRepository> _logger;

        public PostsRepository(DatabaseConfig config, ILogger<PostsRepository> logger)
        {
            _config = config;
            _logger = logger;
        }

        public async Task<Post> GetPostAsync(int postId)
        {
            var getPostsSql = "";
            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync().ConfigureAwait(false);

                    var post = await connection.QuerySingleOrDefaultAsync<Post>(getPostsSql).ConfigureAwait(false);

                    return post;
                }
                catch (Exception exception)
                {
                    _logger.LogError(exception, $"Cannot get post: {postId}");
                }
                finally
                {
                    connection.Close();
                }
            }

            return null;
        }

        public async Task<List<Post>> GetPostsForAuthorAsync(int authorId)
        {
            const string getPostsSql = "";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync().ConfigureAwait(false);

                    var posts = await connection.QuerySingleOrDefaultAsync<List<Post>>(getPostsSql).ConfigureAwait(false);

                    return posts;
                }
                catch (Exception exception)
                {
                    _logger.LogError(exception, "Cannot get posts");
                }
                finally
                {
                    connection.Close();
                }
            }

            return null;
        }

        public async Task<bool> AddPostAsync(Post post)
        {
            const string addPostSql = "";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                await connection.OpenAsync().ConfigureAwait(false);
                var transaction = connection.BeginTransaction();
                try
                {
                    await connection.ExecuteAsync(addPostSql, transaction: transaction).ConfigureAwait(false);

                    return true;
                }
                catch (Exception exception)
                {
                   _logger.LogError(exception, "Cannot add post");

                    transaction.Rollback();
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return false;
        }

        public async Task<bool> DeletePostAsync(int postId)
        {
            const string deletePostSql = "";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                await connection.OpenAsync().ConfigureAwait(false);
                var transaction = connection.BeginTransaction();
                try
                {
                    await connection.ExecuteAsync(deletePostSql, transaction: transaction).ConfigureAwait(false);

                    return true;
                }
                catch (Exception exception)
                {
                    _logger.LogError(exception, "Cannot delete post");

                    transaction.Rollback();
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return false;
        }
    }
}