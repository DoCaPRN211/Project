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
    public partial class frmProfile : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtUsername.Text = LoginInfo.user.Username.ToString();
            txtFullname.Text = LoginInfo.user.Fullname.ToString();
            txtEmail.Text = LoginInfo.user.Email.ToString();
            dtpDoB.Text = LoginInfo.user.Dob.ToString();
            txtGender.Text = (LoginInfo.user.Gender ? "Male" : "Female");
            txtPassword.Text = LoginInfo.user.Password.ToString();
        }

        private void reloadForm()
        {
            txtUsername.Text = LoginInfo.user.Username.ToString();
            txtFullname.Text = LoginInfo.user.Fullname.ToString();
            txtEmail.Text = LoginInfo.user.Email.ToString();
            dtpDoB.Text = LoginInfo.user.Dob.ToString();
            txtGender.Text = (LoginInfo.user.Gender ? "Male" : "Female");
            txtPassword.Text = LoginInfo.user.Password.ToString();
            txtFullname.Enabled = false;
            txtEmail.Enabled = false;
            dtpDoB.Enabled = false;
            rbtnMale.Visible = false;
            rbtnFemale.Visible = false;
            txtGender.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = true;
            btnClose.Location = new Point(255, 351);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtFullname.Enabled = true;
            txtEmail.Enabled = true;
            dtpDoB.Enabled = true;
            rbtnMale.Visible = true;
            rbtnFemale.Visible = true;
            txtGender.Visible = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnClose.Location = new Point(310, 361);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFullname.Enabled = false;
            txtEmail.Enabled = false;
            dtpDoB.Enabled = false;
            rbtnMale.Visible = false;
            rbtnFemale.Visible = false;
            txtGender.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = true;
            btnClose.Location = new Point(278, 361);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoginInfo.user.Fullname = txtFullname.Text;
            LoginInfo.user.Email = txtEmail.Text;
            LoginInfo.user.Dob = DateTime.Parse(dtpDoB.Text);
            LoginInfo.user.Gender = (rbtnMale.Checked ? true : false);
            userRepository.UpdateUser(LoginInfo.user);
            DialogResult d;
            d = MessageBox.Show("Update Profile successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.reloadForm();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmResetPassword f = new frmResetPassword();
            f.ShowDialog();
        }
    }
}
