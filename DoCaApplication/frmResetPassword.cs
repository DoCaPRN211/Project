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
    public partial class frmResetPassword : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCurPass.Text.Equals(userRepository.GetUserById(LoginInfo.user.Id).Password))
            {
                if (txtNewPass.Text.Equals(txtConfirm.Text) && txtNewPass.Text != string.Empty)
                {
                    userRepository.UpdatePassword(userRepository.GetUserById(LoginInfo.user.Id), txtNewPass.Text);
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
                    DialogResult d;
                    d = MessageBox.Show("Confirm Password does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Current Password doesn't exist!", "Warning");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void pbCurrentPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtCurPass.PasswordChar = '\0';
        }

        private void pbCurrentPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtCurPass.PasswordChar = '*';
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
    }
}
