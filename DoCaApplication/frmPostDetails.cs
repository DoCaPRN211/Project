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
    public partial class frmPostDetails : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IPostRepository PostRepository { get; set; }
        IPostRepository PostRepository123 = new PostRepository();
        public ICategoryRepository CategoryRepository = new CategoryRepository();
        public Post Post { get; set; }
        public frmPostDetails()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var post = new Post
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    Isactive = true,
                    Createtime = DateTime.Now,
                    Userid = LoginInfo.user.Id,
                    Categoryid = CategoryRepository.GetCategoryByCategory(cboCate.Text).Id,
                };
                DialogResult d;
                if (!string.IsNullOrEmpty(post.Title.ToString()) && !string.IsNullOrEmpty(post.Content.ToString()) &&
                    !string.IsNullOrEmpty(post.Categoryid.ToString()))
                {
                    string check = "";
                    if (!InsertOrUpdate)
                    {
                        PostRepository.CreatePost(post);
                        check = "Insert";
                    }
                    else
                    {
                    Post.Title = txtTitle.Text;
                    Post.Content = txtContent.Text;
                    Post.Categoryid = CategoryRepository.GetCategoryByCategory(cboCate.Text).Id;
                    PostRepository123.UpdatePost(Post);
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
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Create a new post" : "Edit a post");
            }
}

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPostDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate)
            {
                label4.Text = "Update a Post";
                txtTitle.Text = Post.Title.ToString();
                txtContent.Text = Post.Content.ToString();
                cboCate.Text = CategoryRepository.GetCategoryByCategoryId(Post.Categoryid).Name;
            }
            foreach (var cate in CategoryRepository.GetCategories())
            {
                cboCate.Items.Add(cate.Name);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
