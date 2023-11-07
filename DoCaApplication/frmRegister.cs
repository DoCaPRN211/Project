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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoCaApplication
{
    public partial class frmRegister : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!txtConfirm.Text.Trim().Equals(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Confirm Password does not match!", "DoCa Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (txtUsername.Text.Trim() == "" || txtFullname.Text.Trim() == "" ||
                        txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "" ||
                        txtConfirm.Text.Trim() == "")
                    {
                        MessageBox.Show("All fields are required!", "DoCa Management System",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var userlist = userRepository.GetUsers();
                        var duplicateUsername = string.Empty;
                        var duplicateEmail = string.Empty;
                        foreach (var user in userlist)
                        {
                            if (user.Username.Equals(txtUsername.Text.Trim()))
                            {
                                duplicateUsername = user.Username;
                            }
                            if (user.Email.Equals(txtEmail.Text.Trim()))
                            {
                                duplicateEmail = user.Email;
                            }
                        }

                        if (duplicateUsername.Equals(txtUsername.Text.Trim()) || duplicateEmail.Equals(txtEmail.Text.Trim()))
                        {
                            MessageBox.Show("User Name or Email Duplicated!", "DoCa Management System",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            var u = new User
                            {
                                Id = Guid.NewGuid().ToString(),
                                Username = txtUsername.Text,
                                Fullname = txtFullname.Text,
                                Email = txtEmail.Text,
                                Dob = DateTime.Parse(dtpDoB.Text),
                                Gender = rbtnMale.Checked,
                                Password = txtPassword.Text,
                                Isactive = true,
                                Isban = false,
                                Role = "MEMBER"
                            };
                            userRepository.CreateUser(u);
                            DialogResult d;
                            d = MessageBox.Show("Register successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (d == DialogResult.OK)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void pbConfirm_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirm.PasswordChar = '\0';
        }

        private void pbConfirm_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirm.PasswordChar = '*';
        }
    }
}
