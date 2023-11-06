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
    public partial class frmMainPage : Form
    {
        IPostRepository postRepository = new PostRepository();
        ICommentRepository commentRepository = new CommentRepository();
        IReactRepository reactRepository = new ReactRepository();
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
                    p.Title,
                    CreateTime = p.Createtime,
                    Reaction = reactRepository.GetReactsByPost(p).Count(),
                    Comment = commentRepository.GetCommentsByPost(p).Count(),
                }).OrderBy(p => p.CreateTime).ToList();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Post List");
            }
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
            txtPost.Visible = true;
            txtPost1.Visible = true;
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
    }
}
