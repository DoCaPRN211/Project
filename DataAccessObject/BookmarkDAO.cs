using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class BookmarkDAO
    {
        private static BookmarkDAO instance = null;
        private static object instanceLock = new object();
        private BookmarkDAO() { }
        public static BookmarkDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookmarkDAO();
                }
                return instance;
            }
        }

        public List<Bookmark> GetBookmarks()
        {
            using var db = new DoCaPrnContext();
            return db.Bookmarks.ToList();
        }

        public List<Bookmark> GetBookmarksByUserId(string id)
        {
            var list = GetBookmarks().Where(b => b.Isactive && b.Userid.Equals(id)).ToList();
            return list;
        }

        public Bookmark GetBookmarkByUserIdAndPostId(string userid, string postid)
        {
            var bookmarks = GetBookmarks();
            if (bookmarks != null)
            {
                var tmp = bookmarks.FirstOrDefault(r =>
                    r.Userid.Equals(userid, StringComparison.OrdinalIgnoreCase) && r.Postid != null &&
                    r.Postid.Equals(postid, StringComparison.OrdinalIgnoreCase));
                return tmp;
            }
            return null;
        }

        public void AddBookmark(Bookmark bookmark)
        {
            using var db = new DoCaPrnContext();
            db.Bookmarks.Add(bookmark);
            db.SaveChanges();
        }

        public void ChangeBookmarkStatus(Bookmark bookmark)
        {
            using var db = new DoCaPrnContext();
            var tmp = GetBookmarkByUserIdAndPostId(bookmark.Userid, bookmark.Postid);
            var r = db.Bookmarks.Find(tmp.Id);
            if (r != null)
            {
                r.Isactive = !tmp.Isactive;
                db.SaveChanges();
            }
        }
    }
}
