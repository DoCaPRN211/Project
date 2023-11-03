using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPostRepository
    {
        List<Post> GetPosts();

        Post GetPostById(Post post);

        void CreatePost(Post post);

        void UpdatePost(Post post); 

        void DeletePost(Post post);
    }
}
