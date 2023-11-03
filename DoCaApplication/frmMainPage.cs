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
        BindingSource BindingSource { get; set; }
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void Bingding(List<Post> list)
        {
            var postList = list.Select(p => new
            {
                p.Title,
                CreateTime = p.Createtime,
                Reaction = p.Reacts.Count(),
                Comment = p.Comments.Count(),
            }).ToList();

            BindingSource = new BindingSource();
            BindingSource.DataSource = postList;

            dgvPost.DataSource = null;
            dgvPost.DataSource = BindingSource;
        }

        private void LoadPostList()
        {
            var list = postRepository.GetPosts().ToList();
            Bingding(list);
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            LoadPostList();
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            frmPostDetails frmPostDetails = new frmPostDetails
            {
                Text = "Create A New Post",
                InsertOrUpdate = false,
                PostRepository = postRepository,
            };
            if (frmPostDetails.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            LoadPostList();
        }

        private void btnUpdatePost_Click(object sender, EventArgs e)
        {
            frmPostDetails frmPostDetails = new frmPostDetails
            {
                Text = "Update A Post",
                InsertOrUpdate = true,
                PostRepository = postRepository,
            };
            if (frmPostDetails.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            LoadPostList();
        }
    }
}
