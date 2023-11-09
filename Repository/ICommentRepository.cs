using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICommentRepository
    {
        List<Comment> GetComments();

        Comment GetCommentByContentAndCreateTime(string content, DateTime createTime);

        List<Comment> GetCommentsByPost(Post post);

        void AddComment(Comment comment);

        void EditComment(Comment comment);

        void DeleteComment(Comment comment);

        void DeleteCommentByUserId(string userid);

        Comment GetCommentById(string commentid);

    }
}
