using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CommentRepository : ICommentRepository
    {
        public List<Comment> GetComments()
            => CommentDAO.Instance.GetComments();

        public Comment GetCommentByContentAndCreateTime(string content, DateTime createTime)
            => CommentDAO.Instance.GetCommentByContentAndCreateTime(content, createTime);

        public List<Comment> GetCommentsByPost(Post post)
            => CommentDAO.Instance.GetCommentsByPost(post);

        public void AddComment(Comment comment)
            => CommentDAO.Instance.AddComment(comment); 

        public void EditComment(Comment comment)
            => CommentDAO.Instance.EditComment(comment);

        public void DeleteComment(Comment comment)
            => CommentDAO.Instance.DeleteComment(comment);

        public void DeleteCommentByUserId(string userid)
            => CommentDAO.Instance.DeleteCommentByUserId(userid);

        public Comment GetCommentById(string commentid)
            => CommentDAO.Instance.GetCommentById(commentid);
    }
}
