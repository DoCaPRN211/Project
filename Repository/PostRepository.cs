using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PostRepository : IPostRepository
    {
        public List<Post> GetPosts() 
            => PostDAO.Instance.GetPosts();

        public Post GetPostById(Post post)
            => PostDAO.Instance.GetPostById(post);

        public Post GetPostByTitleAndCreateTime(string title, DateTime createTime)
            => PostDAO.Instance.GetPostByTitleAndCreateTime(title, createTime);

        public void CreatePost(Post post)
            => PostDAO.Instance.CreatePost(post);

        public void UpdatePost(Post post)
            => PostDAO.Instance.UpdatePost(post);

        public void DeletePost(Post post)
            => PostDAO.Instance.DeletePost(post);
    }
}
