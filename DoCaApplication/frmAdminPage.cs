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
    public partial class frmAdminPage : Form
    {
        IUserRepository userRepository = new UserRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        IPostRepository postRepository = new PostRepository();
        ICommentRepository commentRepository = new CommentRepository();
        IReactRepository reactRepository = new ReactRepository();
        public frmAdminPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadMemberList()
        {
            try
            {
                var list = userRepository.GetUsers();
                List<User> memberlist = new List<User>();
                foreach (var member in list)
                {
                    if (member.Role.Equals("MEMBER") && member.Isactive == true)
                    {
                        memberlist.Add(member);
                    }
                }
                var memlist = memberlist.Select(m => new
                {
                    m.Id,
                    m.Username,
                    m.Password,
                    m.Fullname,
                    m.Email,
                    m.Dob,
                    m.Gender,
                    m.Isactive,
                    m.Isban
                }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = memlist;

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtActive.DataBindings.Clear();
                txtBan.DataBindings.Clear();
                txtDoB.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtGender.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "Id");
                txtUsername.DataBindings.Add("Text", source, "Username");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtFullname.DataBindings.Add("Text", source, "Fullname");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDoB.DataBindings.Add("Text", source, "DoB");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtActive.DataBindings.Add("Text", source, "isActive");
                txtBan.DataBindings.Add("Text", source, "isBan");

                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = source;

                if (memlist.Count() == 0)
                {
                    ClearText();
                    btnActive.Enabled = false;
                }
                else
                {
                    btnActive.Enabled = true;
                    btnBan.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of members");
            }
        }

        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullname.Text = string.Empty;
            txtDoB.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtBan.Text = string.Empty;
            txtActive.Text = string.Empty;
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            txtCategoryId.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            btnUpdateCategory.Enabled = false;
            LoadMemberList();
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            if (txtGender.Text == "True")
            {
                txtGender.Text = "Male";
            }
            else if (txtGender.Text == "False")
            {
                txtGender.Text = "Female";
            }
        }

        private void frmAdminPage_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "-- SearchBy";
            txtSearch.ForeColor = Color.Gray;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "-- SearchBy")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "-- SearchBy";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        public void SearchMemberByUsername(string username)
        {
            try
            {
                var list = userRepository.GetUsers();
                List<User> memberlist = new List<User>();
                foreach (var member in list)
                {
                    if (member.Role.Equals("MEMBER") && member.Username.Contains(username, StringComparison.OrdinalIgnoreCase)
                        && member.Isactive == true)
                    {
                        memberlist.Add(member);
                    }
                }
                var memlist = memberlist.Select(m => new
                {
                    m.Id,
                    m.Username,
                    m.Password,
                    m.Fullname,
                    m.Email,
                    m.Dob,
                    m.Gender,
                    m.Isactive,
                    m.Isban
                }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = memlist;

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtActive.DataBindings.Clear();
                txtBan.DataBindings.Clear();
                txtDoB.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtGender.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "Id");
                txtUsername.DataBindings.Add("Text", source, "Username");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtFullname.DataBindings.Add("Text", source, "Fullname");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDoB.DataBindings.Add("Text", source, "DoB");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtActive.DataBindings.Add("Text", source, "isActive");
                txtBan.DataBindings.Add("Text", source, "isBan");

                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = source;

                if (memlist.Count() == 0)
                {
                    ClearText();
                    btnActive.Enabled = false;
                    btnBan.Enabled = false;
                }
                else
                {
                    btnActive.Enabled = true;
                    btnBan.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of members");
            }
        }

        public void SearchMemberByEmail(string email)
        {
            try
            {
                var list = userRepository.GetUsers();
                List<User> memberlist = new List<User>();
                foreach (var member in list)
                {
                    if (member.Role.Equals("MEMBER") && member.Email != null && member.Isactive == true
                        && member.Email.Contains(email, StringComparison.OrdinalIgnoreCase))
                    {
                        memberlist.Add(member);
                    }
                }
                var memlist = memberlist.Select(m => new
                {
                    m.Id,
                    m.Username,
                    m.Password,
                    m.Fullname,
                    m.Email,
                    m.Dob,
                    m.Gender,
                    m.Isactive,
                    m.Isban
                }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = memlist;

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtActive.DataBindings.Clear();
                txtBan.DataBindings.Clear();
                txtDoB.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtGender.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "Id");
                txtUsername.DataBindings.Add("Text", source, "Username");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtFullname.DataBindings.Add("Text", source, "Fullname");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDoB.DataBindings.Add("Text", source, "DoB");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtActive.DataBindings.Add("Text", source, "isActive");
                txtBan.DataBindings.Add("Text", source, "isBan");

                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = source;

                if (memlist.Count() == 0)
                {
                    ClearText();
                    btnActive.Enabled = false;
                    btnBan.Enabled = false;
                }
                else
                {
                    btnActive.Enabled = true;
                    btnBan.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of members");
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdateCategory.Enabled = false;
                txtCategoryId.Text = string.Empty;
                txtCategoryName.Text = string.Empty;
                SearchMemberByUsername(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member by username");
            }
        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdateCategory.Enabled = false;
                txtCategoryId.Text = string.Empty;
                txtCategoryName.Text = string.Empty;
                SearchMemberByEmail(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member by email");
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to change banned status of this member?", "Member Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    User u = new User();
                    var list = userRepository.GetUsers();
                    foreach (var mem in list)
                    {
                        if (mem.Id.Equals(txtMemberId.Text)) u = mem;
                    }
                    if (u != null)
                    {
                        userRepository.BanUser(u);
                    }
                    LoadMemberList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Member Management");
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this member?", "Member Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    User u = new User();
                    var list = userRepository.GetUsers();
                    foreach (var mem in list)
                    {
                        if (mem.Id.Equals(txtMemberId.Text)) u = mem;
                    }
                    if (u != null)
                    {
                        userRepository.DeleteUser(u);
                        postRepository.DeletePostByUserId(u.Id);
                        commentRepository.DeleteCommentByUserId(u.Id);
                        reactRepository.DeleteReactByUserId(u.Id);
                    }
                    LoadMemberList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Member Management");
            }
        }

        public void ShowBannedMembers()
        {
            try
            {
                var list = userRepository.GetUsers();
                List<User> memberlist = new List<User>();
                foreach (var member in list)
                {
                    if (member.Role.Equals("MEMBER") && member.Isactive == true && member.Isban == true)
                    {
                        memberlist.Add(member);
                    }
                }
                var memlist = memberlist.Select(m => new
                {
                    m.Id,
                    m.Username,
                    m.Password,
                    m.Fullname,
                    m.Email,
                    m.Dob,
                    m.Gender,
                    m.Isactive,
                    m.Isban
                }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = memlist;

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtActive.DataBindings.Clear();
                txtBan.DataBindings.Clear();
                txtDoB.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtGender.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "Id");
                txtUsername.DataBindings.Add("Text", source, "Username");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtFullname.DataBindings.Add("Text", source, "Fullname");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDoB.DataBindings.Add("Text", source, "DoB");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtActive.DataBindings.Add("Text", source, "isActive");
                txtBan.DataBindings.Add("Text", source, "isBan");

                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = source;

                if (memlist.Count() == 0)
                {
                    ClearText();
                    btnBan.Enabled = false;
                }
                else
                {
                    btnBan.Enabled = true;
                    btnActive.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of banned members");
            }
        }

        private void btnShowBanned_Click(object sender, EventArgs e)
        {
            btnUpdateCategory.Enabled = false;
            txtCategoryId.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            ShowBannedMembers();
        }

        public void LoadCategoryList()
        {
            try
            {
                var catelist = categoryRepository.GetCategories().ToList();
                var list = catelist.Select(c => new
                {
                    c.Id,
                    c.Name
                }).ToList();

                BindingSource source = new BindingSource();
                source.DataSource = list;

                txtCategoryId.DataBindings.Clear();
                txtCategoryName.DataBindings.Clear();

                txtCategoryId.DataBindings.Add("Text", source, "Id");
                txtCategoryName.DataBindings.Add("Text", source, "Name");

                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = source;

                if (list.Count() == 0)
                {
                    btnUpdateCategory.Enabled = false;
                }
                else
                {
                    btnUpdateCategory.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            btnActive.Enabled = false;
            btnBan.Enabled = false;
            ClearText();
            LoadCategoryList();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            frmCategoryDetail frmCategoryDetail = new frmCategoryDetail
            {
                Text = "Add category",
                InsertOrUpdate = false,
                CategoryRepository = categoryRepository
            };
            if (frmCategoryDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCategoryList();
            }
            frmCategoryDetail.Close();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            frmCategoryDetail frmCategoryDetail = new frmCategoryDetail
            {
                Text = "Update category",
                InsertOrUpdate = true,
                CategoryDetail = categoryRepository.GetCategoryByCategory(txtCategoryName.Text),
                CategoryRepository = categoryRepository
            };
            if (frmCategoryDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCategoryList();
            }
            frmCategoryDetail.Close();
        }
    }
}
