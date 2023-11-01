using Repository;

namespace DoCaApplication
{
    public partial class frmLogin : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tmp = userRepository.checkLogin(txtEmail.Text, txtPassword.Text);

            if (tmp != null)
            {
                frmMain f = new frmMain();

                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("You have no permission to do this function!", "DoCa Management");
        }
        //troll
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}