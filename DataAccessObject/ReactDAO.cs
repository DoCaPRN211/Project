using BusinessObject.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ReactDAO
    {
        private static ReactDAO instance = null;
        private static object instanceLock = new object();
        private ReactDAO() { }
        public static ReactDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReactDAO();
                }
                return instance;
            }
        }

        public List<React> GetReacts()
        {
            using var db = new DoCaPrnContext();
            return db.Reacts.ToList();
        }

        public React GetReactByUserIdAndPostId(string userId, string id)
        {
            var reacts = GetReacts();

            if (reacts != null)
            {
                var tmp = reacts.FirstOrDefault(r =>
                    r.Userid.Equals(userId, StringComparison.OrdinalIgnoreCase) && r.Postid != null &&
                    r.Postid.Equals(id, StringComparison.OrdinalIgnoreCase) &&
                    r.Commentid == null);

                return tmp;
            }

            return null;
        }

        public React GetReactByUserIdAndCommentId(string userId, string id)
        {
            var reacts = GetReacts();

            if (reacts != null)
            {
                var tmp = reacts.FirstOrDefault(r =>
                    r.Userid.Equals(userId, StringComparison.OrdinalIgnoreCase) && r.Commentid != null &&
                    r.Commentid.Equals(id, StringComparison.OrdinalIgnoreCase) &&
                    r.Postid == null);

                return tmp;
            }

            return null;
        }

        public List<React> GetReactsByPost(Post post)
        {
            var tmp = GetReacts().Where(r => r.Isactive && r.Postid != null && r.Postid.Equals(post.Id)).ToList();
            return tmp;
        }

        public List<React> GetReactsByComment(Comment comment)
        {
            var tmp = GetReacts().Where(r => r.Isactive && r.Commentid != null && r.Commentid.Equals(comment.Id)).ToList();
            return tmp;
        }

        public void AddReact(React react)
        {
            using var db = new DoCaPrnContext();
            db.Reacts.Add(react);
            db.SaveChanges();
        }

        public void ChangeReactStatusByComment(React react)
        {
            using var db = new DoCaPrnContext();
            var tmp = GetReactByUserIdAndCommentId(react.Userid, react.Commentid);
            var r = db.Reacts.Find(tmp.Id);
            if (r != null)
            {
                r.Isactive = !tmp.Isactive;
                db.SaveChanges();
            }
        }

        public void ChangeReactStatusByPost(React react)
        {
            using var db = new DoCaPrnContext();
            var tmp = GetReactByUserIdAndPostId(react.Userid, react.Postid);
            var r = db.Reacts.Find(tmp.Id);
            if (r != null)
            {
                r.Isactive = !tmp.Isactive;
                db.SaveChanges();
            }
        }
    }
}
