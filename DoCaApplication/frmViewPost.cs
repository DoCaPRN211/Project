using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoCaApplication
{
    public partial class frmViewPost : Form
    {
        public Post post { get; set; }
        public IPostRepository postRepository = new PostRepository();
        ICommentRepository commentRepository = new CommentRepository();
        IBookmarkRepository bookmarkRepository = new BookmarkRepositoy();
        public IReactRepository reactRepository { get; set; }
        BindingSource BindingSource { get; set; }
        public frmViewPost()
        {
            InitializeComponent();
        }

        private void Binding(List<Comment> comments)
        {
            var list = comments.Where(c => c.Isactive).Select(c => new
            {
                c.Content,
                CreateTime = c.Createtime,
                React = reactRepository.GetReactsByComment(c).Count(),
            }).OrderByDescending(c => c.CreateTime).ToList();

            BindingSource = new BindingSource();
            BindingSource.DataSource = list;

            txtComment.DataBindings.Clear();
            txtCreateTime.DataBindings.Clear();
            txtComment.DataBindings.Add("Text", BindingSource, "Content");
            txtCreateTime.DataBindings.Add("Text", BindingSource, "CreateTime");

            dgvComment.DataSource = null;
            dgvComment.DataSource = BindingSource;

            if (list.Count == 0)
            {
                btnViewComment.Enabled = false;
            }
            else
            {
                btnViewComment.Enabled = true;
            }
        }

        private void LoadCommentList()
        {
            var list = commentRepository.GetCommentsByPost(post);
            Binding(list);
        }

        private void LoadPost()
        {
            txtTitle.Text = post.Title;
            txtContent.Text = post.Content;
            txtId.Text = post.Createtime.ToString();
            LoadCommentList();
        }

        private void frmViewPost_Load(object sender, EventArgs e)
        {
            txtTitle.Text = post.Title;
            txtContent.Text = post.Content;
            txtCreateTime.Visible = true;
            txtComment.Visible = true;
            txtId.Text = post.Createtime.ToString();

            if (post.Userid.Equals(LoginInfo.user.Id) && LoginInfo.user.Isban)
            {
                lbBan.Visible = true;
                btnAddComment.Enabled = false;
                btnEditPost.Enabled = false;
            }

            if (post.Userid.Equals(LoginInfo.user.Id))
            {
                btnDelete.Visible = true;
                btnEditPost.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                btnEditPost.Visible = false;
            }

            if (reactRepository.GetReactByUserIdAndPostId(LoginInfo.user.Id, post.Id) != null)
            {
                if (reactRepository.GetReactByUserIdAndPostId(LoginInfo.user.Id, post.Id).Isactive)
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

            if (bookmarkRepository.GetBookmarkByUserIdAndPostId(LoginInfo.user.Id, post.Id) != null)
            {
                if (bookmarkRepository.GetBookmarkByUserIdAndPostId(LoginInfo.user.Id, post.Id).Isactive)
                {
                    btnBookmark.Text = "Unbookmark";
                }
                else
                {
                    btnBookmark.Text = "Save as Bookmark";
                }
            }
            else
            {
                btnBookmark.Text = "Save as Bookmark";
            }
            LoadCommentList();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            frmComment f = new frmComment
            {
                ViewOrAdd = false,
                commentRepository = commentRepository,
                post = post,
                reactRepository = reactRepository,
            };
            f.ShowDialog();
            LoadCommentList();
        }

        private void btnViewComment_Click(object sender, EventArgs e)
        {
            frmComment f = new frmComment
            {
                ViewOrAdd = true,
                Comment = commentRepository.GetCommentByContentAndCreateTime(txtComment.Text, DateTime.Parse(txtCreateTime.Text)),
                post = post,
                reactRepository = reactRepository,
                commentRepository = commentRepository,
            };
            f.ShowDialog();
            LoadCommentList();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            var react = new React
            {
                Id = Guid.NewGuid().ToString(),
                Isactive = true,
                Createtime = DateTime.Now,
                Postid = post.Id,
                Commentid = null,
                Userid = LoginInfo.user.Id,
            };
            if (reactRepository.GetReactByUserIdAndPostId(LoginInfo.user.Id, post.Id) != null)
            {
                reactRepository.ChangeReactStatusByPost(react);
            }
            else
            {
                reactRepository.AddReact(react);
            }
            btnLike.Text = (btnLike.Text.Equals("Like") ? "Unlike" : "Like");
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            frmPostDetails f = new frmPostDetails
            {
                Text = "Update A Post",
                InsertOrUpdate = true,
                Post = post,
                PostRepository = postRepository,
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            LoadPost();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this post?", "Delete Post",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    postRepository.DeletePost(post);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Post");
            }
        }

        private void btnBookmark_Click(object sender, EventArgs e)
        {
            var bookmark = new Bookmark
            {
                Id = Guid.NewGuid().ToString(),
                Isactive = true,
                Createtime = DateTime.Now,
                Postid = post.Id,
                Userid = LoginInfo.user.Id,
            };
            if (bookmarkRepository.GetBookmarkByUserIdAndPostId(LoginInfo.user.Id, post.Id) != null)
            {
                bookmarkRepository.ChangeBookmarkStatus(bookmark);
            }
            else
            {
                bookmarkRepository.AddBookmark(bookmark);
            }
            btnBookmark.Text = (btnBookmark.Text.Equals("Save as Bookmark") ? "Unbookmark" : "Save as Bookmark");
        }
    }
}
