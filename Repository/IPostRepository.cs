using BusinessObject.Models;
using DataAccessObject;
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

        Post GetPostById(string postid);

        Post GetPostByTitleAndCreateTime(string title, DateTime createTime);

        void CreatePost(Post post);

        void UpdatePost(Post post); 

        void DeletePost(Post post);
    }
}
