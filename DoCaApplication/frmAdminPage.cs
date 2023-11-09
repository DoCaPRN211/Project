using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoCaApplication
{
    public partial class frmAdminPage : Form
    {
        IUserRepository userRepository = new UserRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        IPostRepository postRepository = new PostRepository();
        ICommentRepository commentRepository = new CommentRepository();
        IReactRepository reactRepository = new ReactRepository();
        IReportRepository reportRepository = new ReportRepository();
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
            btnDeleteReport.Enabled = false;
            btnView.Enabled = false;
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
            txtReportId.Visible = false;
            txtReportUsername.Visible = false;
            btnActive.Enabled = false;
            btnBan.Enabled = false;
            btnUpdateCategory.Enabled = false;
            btnDeleteReport.Enabled = false;
            btnView.Enabled = false;
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
                btnDeleteReport.Enabled = false;
                txtCategoryId.Text = string.Empty;
                txtCategoryName.Text = string.Empty;
                btnView.Enabled = false;
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
                btnDeleteReport.Enabled = false;
                txtCategoryId.Text = string.Empty;
                txtCategoryName.Text = string.Empty;
                btnView.Enabled = false;
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
            btnDeleteReport.Enabled = false;
            txtCategoryId.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            btnView.Enabled = false;
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
            btnDeleteReport.Enabled = false;
            btnView.Enabled = false;
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

        private void btnShowPostReport_Click(object sender, EventArgs e)
        {
            cboReport.Items.Clear();
            cboReport.Text = string.Empty;
            cboReport.Items.Add("Delete reports related to this post");
            cboReport.Items.Add("Delete post reports of this user");
            btnActive.Enabled = false;
            btnBan.Enabled = false;
            btnUpdateCategory.Enabled = false;
            ClearText();
            LoadReportPost();
        }

        private void btnShowCommentReport_Click(object sender, EventArgs e)
        {
            cboReport.Items.Clear();
            cboReport.Text = string.Empty;
            cboReport.Items.Add("Delete reports related to this comment");
            cboReport.Items.Add("Delete comment reports of this user");
            btnActive.Enabled = false;
            btnBan.Enabled = false;
            btnUpdateCategory.Enabled = false;
            ClearText();
            LoadReportComment();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (postRepository.GetPostById(txtReportId.Text) != null)
            {
                frmViewPost f = new frmViewPost
                {
                    IsAdmin = true,
                    post = postRepository.GetPostById(txtReportId.Text),
                    reactRepository = reactRepository
                };
                f.ShowDialog();
                LoadReportPost();
            }
            else if (commentRepository.GetCommentById(txtReportId.Text) != null)
            {
                frmComment f = new frmComment
                {
                    ViewOrAdd = true,
                    Comment = commentRepository.GetCommentById(txtReportId.Text),
                    reactRepository = reactRepository,
                    commentRepository = commentRepository,
                    IsAdmin = true,
                };
                f.ShowDialog();
                LoadReportComment();
            }
            else
            {
                MessageBox.Show("Error", "View Report");
            }
        }

        private void LoadReportComment()
        {
            try
            {
                var reportlist = reportRepository.GetReports().Where(r => r.Isactive && r.Postid == null).Select(r => new
                {
                    r.Id,
                    r.Message,
                    r.Commentid,
                    Username = userRepository.GetUserById(r.Userid).Username,
                }).OrderBy(r => r.Commentid).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = reportlist;

                txtReportId.DataBindings.Clear();
                txtReportUsername.DataBindings.Clear();
                txtReportId.DataBindings.Add("Text", source, "Commentid");
                txtReportUsername.DataBindings.Add("Text", source, "Username");

                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = source;

                if (reportlist.Count() == 0)
                {
                    txtReportId.Text = string.Empty;
                    txtReportUsername.Text = string.Empty;
                    btnView.Enabled = false;
                    btnDeleteReport.Enabled = false;
                }
                else
                {
                    btnDeleteReport.Enabled = true;
                    btnView.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of reports");
            }
        }

        private void LoadReportPost()
        {
            try
            {
                var reportlist = reportRepository.GetReports().Where(r => r.Isactive && r.Commentid == null).Select(r => new
                {
                    r.Id,
                    r.Message,
                    r.Postid,
                    Username = userRepository.GetUserById(r.Userid).Username,
                }).OrderBy(r => r.Postid).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = reportlist;

                txtReportId.DataBindings.Clear();
                txtReportUsername.DataBindings.Clear();
                txtReportId.DataBindings.Add("Text", source, "Postid");
                txtReportUsername.DataBindings.Add("Text", source, "Username");

                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = source;

                if (reportlist.Count() == 0)
                {
                    txtReportId.Text = string.Empty;
                    txtReportUsername.Text = string.Empty;
                    btnView.Enabled = false;
                    btnDeleteReport.Enabled = false;
                }
                else
                {
                    btnDeleteReport.Enabled = true;
                    btnView.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of reports");
            }
        }

        private void txtReportId_TextChanged(object sender, EventArgs e)
        {
            if (txtReportId.Text == string.Empty)
            {
                btnView.Enabled = false;
            }
            else
            {
                btnView.Enabled = true;
            }
        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboReport.Text == string.Empty)
                {
                    MessageBox.Show("Delete action needed!", "Delete Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Do you really want to delete report?", "Report Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (d == DialogResult.OK)
                    {
                        if (cboReport.Text == "Delete reports related to this post")
                        {
                            reportRepository.DeleteReportByPostId(txtReportId.Text);
                            LoadReportPost();
                        }
                        else if (cboReport.Text == "Delete post reports of this user")
                        {
                            reportRepository.DeleteReportByUserIdAndPostId(
                                userRepository.GetUserByUsername(txtReportUsername.Text).Id, txtReportId.Text);
                            LoadReportPost();
                        }
                        else if (cboReport.Text == "Delete reports related to this comment")
                        {
                            reportRepository.DeleteReportByCommentId(txtReportId.Text);
                            LoadReportComment();
                        }
                        else if (cboReport.Text == "Delete comment reports of this user")
                        {
                            reportRepository.DeleteReportByUserIdAndCommentId(
                                userRepository.GetUserByUsername(txtReportUsername.Text).Id, txtReportId.Text);
                            LoadReportComment();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting reports");
            }
        }
    }
}
