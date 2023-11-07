using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReactRepository : IReactRepository
    {
        public List<React> GetReacts()
            => ReactDAO.Instance.GetReacts();
        public React GetReactByUserIdAndPostId(string userId, string id)
            => ReactDAO.Instance.GetReactByUserIdAndPostId(userId, id);

        public React GetReactByUserIdAndCommentId(string userId, string id)
            => ReactDAO.Instance.GetReactByUserIdAndCommentId(userId, id);

        public List<React> GetReactsByPost(Post post)
            => ReactDAO.Instance.GetReactsByPost(post);

        public List<React> GetReactsByComment(Comment comment)
            => ReactDAO.Instance.GetReactsByComment(comment);

        public void AddReact(React react)
            => ReactDAO.Instance.AddReact(react);

        public void ChangeReactStatusByPost(React react)
            => ReactDAO.Instance.ChangeReactStatusByPost(react);

        public void ChangeReactStatusByComment(React react)
            => ReactDAO.Instance.ChangeReactStatusByComment(react);

        public void DeleteReactByUserId(string userid)
            => ReactDAO.Instance.DeleteReactByUserId(userid);
    }
}
