using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBookmarkRepository
    {
        List<Bookmark> GetBookmarks();
        List<Bookmark> GetBookmarksByUserId(string id);
        void AddBookmark(Bookmark bookmark);
        void ChangeBookmarkStatus(Bookmark bookmark);
        Bookmark GetBookmarkByUserIdAndPostId(string userid, string postid);
    }
}
