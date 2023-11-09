using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CommentDAO
    {
        private static CommentDAO instance = null;
        private static object instanceLock = new object();
        private CommentDAO() { }
        public static CommentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommentDAO();
                }
                return instance;
            }
        }

        public List<Comment> GetComments()
        {
            using var db = new DoCaPrnContext();
            return db.Comments.ToList();
        }

        public Comment GetCommentByContentAndCreateTime(string content, DateTime createTime) 
        {
            var tmp = GetComments().SingleOrDefault(c => c.Isactive && c.Content.Equals(content) && c.Createtime == createTime);
            return tmp;
        }

        public List<Comment> GetCommentsByPost(Post post)
        {
            var tmp = GetComments().Where(c => c.Isactive && c.Postid.Equals(post.Id)).ToList();
            return tmp;
        }

        public Comment GetCommentById(string commentid)
        {
            var tmp = GetComments().SingleOrDefault(p => p.Isactive && p.Id.Equals(commentid));
            return tmp;
        }

        public void DeleteCommentByUserId(string userid)
        {
            using var db = new DoCaPrnContext();
            var p = db.Comments.Where(p => p.Userid == userid);
            if (p != null)
            {
                foreach (var comment in p)
                {
                    comment.Isactive = false;
                }
                db.SaveChanges();
            }
        }

        public void AddComment(Comment comment)
        {
            using var db = new DoCaPrnContext();
            db.Comments.Add(comment);
            db.SaveChanges();
        }

        public void EditComment(Comment comment)
        {
            using var db = new DoCaPrnContext();
            var c = db.Comments.Find(comment.Id);
            if (c != null)
            {
                c.Content = comment.Content;
                db.SaveChanges();
            }
        }

        public void DeleteComment(Comment comment)
        {
            using var db = new DoCaPrnContext();
            var c = db.Comments.Find(comment.Id);
            if (c != null)
            {
                c.Isactive = false;
                db.SaveChanges();
            }
        }
    }
}
