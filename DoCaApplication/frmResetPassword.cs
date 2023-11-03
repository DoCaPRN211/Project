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
                if (txtNewPass.Text.Equals(txtConfirm.Text))
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
    }
}
