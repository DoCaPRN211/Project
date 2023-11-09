using BusinessObject.Models;
using Microsoft.VisualBasic.Devices;
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
    public partial class frmMainPage : Form
    {
        IPostRepository postRepository = new PostRepository();
        ICommentRepository commentRepository = new CommentRepository();
        IReactRepository reactRepository = new ReactRepository();
        IBookmarkRepository bookmarkRepository = new BookmarkRepositoy();
        IUserRepository userRepository = new UserRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        BindingSource BindingSource { get; set; }
        Post post { get; set; }
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtPost.Text = string.Empty;
            txtPost1.Text = string.Empty;
        }

        private void Binding(List<Post> list)
        {
            try
            {
                var postList = list.Where(p => p.Isactive).Select(p => new
                {
                    PostedBy = userRepository.GetUserById(p.Userid).Username,
                    p.Title,
                    Category = categoryRepository.GetCategoryByCategoryId(p.Categoryid).Name,
                    CreateTime = p.Createtime,
                    Reaction = reactRepository.GetReactsByPost(p).Count(),
                    Comment = commentRepository.GetCommentsByPost(p).Count(),
                }).OrderByDescending(p => p.CreateTime).ToList();

                BindingSource = new BindingSource();
                BindingSource.DataSource = postList;

                txtPost.DataBindings.Clear();
                txtPost1.DataBindings.Clear();

                txtPost.DataBindings.Add("Text", BindingSource, "Title");
                txtPost1.DataBindings.Add("Text", BindingSource, "CreateTime");

                dgvPost.DataSource = null;
                dgvPost.DataSource = BindingSource;

                if (postList.Count == 0)
                {
                    ClearText();
                    btnViewPost.Enabled = false;
                }
                else
                {
                    btnViewPost.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Post List");
            }
        }

        private void SearchPost(string keyword)
        {
            ClearText();
            var list = postRepository.GetPosts().ToList();
            var searchlist = new List<Post>();
            foreach (var post in list)
            {
                if (post.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    post.Content.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    searchlist.Add(post);
                }
            }
            Binding(searchlist);
        }

        private void GetBookmarkList()
        {
            ClearText();
            var list = bookmarkRepository.GetBookmarks().ToList();
            var bookmarklist = new List<Post>();
            foreach (var bookmark in list)
            {
                if (bookmark.Userid.Equals(LoginInfo.user.Id) && bookmark.Isactive)
                {
                    if (postRepository.GetPostById(bookmark.Postid) != null)
                    {
                        bookmarklist.Add(postRepository.GetPostById(bookmark.Postid));
                    }
                }
            }
            Binding(bookmarklist);
        }

        private void GetPostByUser()
        {
            ClearText();
            var list = postRepository.GetPosts().ToList();
            var postlist = new List<Post>();
            foreach (var post in list)
            {
                if (post.Userid.Equals(LoginInfo.user.Id))
                {
                    postlist.Add(post);
                }
            }
            Binding(postlist);
        }

        private void LoadPostList()
        {
            ClearText();
            var list = postRepository.GetPosts().ToList();
            Binding(list);
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            LoadPostList();
            txtPost.Visible = false;
            txtPost1.Visible = false;
            if (LoginInfo.user.Isban)
            {
                lbBan.Visible = true;
                btnCreatePost.Enabled = false;
            }
            var cate = categoryRepository.GetCategories().ToList();
            cboSort.DataSource = cate;
            cboSort.DisplayMember = "Name";
            cboSort.ValueMember = "Id";
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            frmPostDetails frmPostDetails = new frmPostDetails
            {
                Text = "Create A New Post",
                InsertOrUpdate = false,
            };
            if (frmPostDetails.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            LoadPostList();
        }

        private void btnViewPost_Click(object sender, EventArgs e)
        {
            frmViewPost f = new frmViewPost
            {
                Text = "View Post",
                post = postRepository.GetPostByTitleAndCreateTime(txtPost.Text, DateTime.Parse(txtPost1.Text)),
                reactRepository = reactRepository,
            };
            f.ShowDialog();
            LoadPostList();
        }

        private void dgvPost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmViewPost f = new frmViewPost
            {
                Text = "View Post",
                post = postRepository.GetPostByTitleAndCreateTime(txtPost.Text, DateTime.Parse(txtPost1.Text)),
                reactRepository = reactRepository,
            };
            f.ShowDialog();
            LoadPostList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPost(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LoadPostList();
        }

        private void btnShowPost_Click(object sender, EventArgs e)
        {
            GetPostByUser();
        }

        private void btnBookmark_Click(object sender, EventArgs e)
        {
            GetBookmarkList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ClearText();
            var list = postRepository.GetPosts().ToList();
            var sortlist = new List<Post>();
            foreach (var post in list)
            {
                if (post.Categoryid.ToString() == cboSort.SelectedValue.ToString())
                {
                    sortlist.Add(post);
                }
            }
            Binding(sortlist);
        }
    }
}
