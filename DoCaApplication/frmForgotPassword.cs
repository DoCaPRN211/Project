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
    public partial class frmForgotPassword : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void pbNewPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPass.PasswordChar = '\0';
        }

        private void pbNewPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPass.PasswordChar = '*';
        }

        private void pbConfirm_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirm.PasswordChar = '\0';
        }

        private void pbConfirm_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirm.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (userRepository.GetUserByUsernameAndEmail(txtUsername.Text, txtEmail.Text) != null)
                {
                    if (txtConfirm.Text.Equals(txtNewPass.Text) && txtNewPass.Text != string.Empty)
                    {
                        userRepository.UpdatePassword(userRepository.GetUserByUsernameAndEmail(txtUsername.Text, txtEmail.Text), txtNewPass.Text);
                        DialogResult d;
                        d = MessageBox.Show("Password has changed successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            frmLogin f = new frmLogin();
                            f.Show();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confirm Password doesn't match!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Username or Email doesn't exist!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }
    }
}
