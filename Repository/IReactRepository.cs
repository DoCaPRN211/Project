using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReactRepository
    {
        List<React> GetReacts();

        React GetReactByUserIdAndPostId(string userId, string id);

        React GetReactByUserIdAndCommentId(string userId, string id);

        List<React> GetReactsByPost(Post post);

        List<React> GetReactsByComment(Comment comment);

        void AddReact(React react);

        void ChangeReactStatusByPost(React react);

        void ChangeReactStatusByComment(React react);

        void DeleteReactByUserId(string userid);
    }
}
