using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookmarkRepositoy : IBookmarkRepository
    {
        public void AddBookmark(Bookmark bookmark)
            => BookmarkDAO.Instance.AddBookmark(bookmark);

        public void ChangeBookmarkStatus(Bookmark bookmark)
            => BookmarkDAO.Instance.ChangeBookmarkStatus(bookmark); 

        public List<Bookmark> GetBookmarks()
            => BookmarkDAO.Instance.GetBookmarks();

        public List<Bookmark> GetBookmarksByUserId(string id)
            => BookmarkDAO.Instance.GetBookmarksByUserId(id);

        public Bookmark GetBookmarkByUserIdAndPostId(string userid, string postid)
            => BookmarkDAO.Instance.GetBookmarkByUserIdAndPostId(userid, postid);
    }
}
