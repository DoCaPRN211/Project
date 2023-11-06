using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoCaApplication
{
    public partial class frmComment : Form
    {
        public bool ViewOrAdd { get; set; }
        public Comment Comment { get; set; }
        public ICommentRepository commentRepository { get; set; }
        public IReactRepository reactRepository { get; set; }
        public Post post { get; set; }

        public frmComment()
        {
            InitializeComponent();
        }

        private void frmComment_Load(object sender, EventArgs e)
        {
            if (ViewOrAdd)
            {
                txtComment.Text = Comment.Content;
                txtComment.ReadOnly = true;
                btnLike.Visible = true;
                btnAddComment.Visible = false;
                if (Comment.Userid.Equals(LoginInfo.user.Id))
                {
                    btnDelete.Visible = true;
                    btnEdit.Visible = true;
                }
                else
                {
                    btnDelete.Visible = false;
                    btnEdit.Visible = false;
                }
            }
            else
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                btnLike.Visible = false;
                btnAddComment.Visible = true;
            }
            if (ViewOrAdd)
            {
                if (reactRepository.GetReactByUserIdAndCommentId(LoginInfo.user.Id, Comment.Id) != null)
                {
                    if (reactRepository.GetReactByUserIdAndCommentId(LoginInfo.user.Id, Comment.Id).Isactive)
                    {
                        btnLike.Text = "Unlike";
                    }
                    else
                    {
                        btnLike.Text = "Like";
                    }
                }
                else
                {
                    btnLike.Text = "Like";
                }
            }
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            try
            {
                var comment = new Comment
                {
                    Id = Guid.NewGuid().ToString(),
                    Content = txtComment.Text,
                    Isactive = true,
                    Createtime = DateTime.Now,
                    Userid = LoginInfo.user.Id,
                    Postid = post.Id
                };
                DialogResult d;
                if (!string.IsNullOrEmpty(post.Title.ToString()) && !string.IsNullOrEmpty(post.Content.ToString()) &&
                    !string.IsNullOrEmpty(post.Categoryid.ToString()))
                {
                    string check = "";
                    if (!ViewOrAdd)
                    {
                        commentRepository.AddComment(comment);
                        check = "Comment";
                    }
                    else
                    {
                        commentRepository.EditComment(comment);
                        check = "Update";
                    }
                    d = MessageBox.Show(check + " successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (d == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    d = MessageBox.Show("Please fill all the blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ViewOrAdd == false ? "Add a new Comment" : "Edit a Comment");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            var react = new React
            {
                Id = Guid.NewGuid().ToString(),
                Isactive = true,
                Createtime = DateTime.Now,
                Postid = null,
                Commentid = Comment.Id,
                Userid = LoginInfo.user.Id,
            };
            if (reactRepository.GetReactByUserIdAndCommentId(LoginInfo.user.Id, Comment.Id) != null)
            {
                reactRepository.ChangeReactStatusByComment(react);
            }
            else
            {
                reactRepository.AddReact(react);
            }
            btnLike.Text = (btnLike.Text.Equals("Like") ? "Unlike" : "Like");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("Edit"))
            {
                txtComment.ReadOnly = false;
                btnEdit.Text = "Save";
            }
            else
            {
                txtComment.ReadOnly = true;
                btnEdit.Text = "Edit";
                Comment.Content = txtComment.Text;
                commentRepository.EditComment(Comment);
                DialogResult d;
                d = MessageBox.Show("Edit successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this comment?", "Delete Comment",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    commentRepository.DeleteComment(Comment);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Comment");
            }
        }
    }
}
