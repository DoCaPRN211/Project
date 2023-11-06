using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class PostDAO
    {
        private static PostDAO instance = null;
        private static object instanceLock = new object();
        private PostDAO() { }
        public static PostDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PostDAO();
                }
                return instance;
            }
        }

        public List<Post> GetPosts()
        {
            using var db = new DoCaPrnContext();
            return db.Posts.ToList();
        }

        public Post GetPostById(Post post)
        {
            var tmp = GetPosts().SingleOrDefault(p => p.Id.Equals(post.Id));
            return tmp;
        }

        public Post GetPostByTitleAndCreateTime(string title, DateTime createTime)
        {
            var tmp = GetPosts().SingleOrDefault(p => p.Title.Equals(title) && p.Createtime == createTime);
            return tmp;
        }

        public void CreatePost(Post post)
        {
            using var db = new DoCaPrnContext();
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            using var db = new DoCaPrnContext();
            db.Posts.Update(post);
            db.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            using var db = new DoCaPrnContext();
            var p = db.Posts.Find(post.Id);
            if (p != null)
            {
                p.Isactive = false;
                db.SaveChanges();
            }
        }
    }
}
