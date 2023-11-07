using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoCaApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&Forum");
            ToolStripMenuItem menuProfile = new ToolStripMenuItem("&Profile");
            ToolStripMenuItem menuMainPage = new ToolStripMenuItem("&Main Page");
            ToolStripMenuItem menuAdminPage = new ToolStripMenuItem("&Admin Page");
            ToolStripMenuItem menuLogout = new ToolStripMenuItem("&Logout");
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem menuWindow = new ToolStripMenuItem("&Window");
            ToolStripSeparator separator = new ToolStripSeparator();

            //mainMenu
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, menuWindow });
            mainMenu.MdiWindowListItem = menuWindow;

            //menuFile
            if (LoginInfo.user.Role.Equals("ADMIN"))
            {
                menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuProfile, separator, menuMainPage, menuAdminPage, separator, menuLogout, menuExit });
            }
            else
            {
                menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuProfile, separator, menuMainPage, separator, menuLogout, menuExit });
            }

            //menuProfile
            menuProfile.Click += new EventHandler(menuProfile_Click);

            //menuMainPage
            menuMainPage.Click += new EventHandler(menuMainPage_Click);

            //menuAdminPage
            menuAdminPage.Click += new EventHandler(menuAdminPage_Click);

            //menuLogout
            menuLogout.Click += new EventHandler(menuLogout_Click);

            //menuExit
            menuExit.Click += new EventHandler(menuExit_Click);
        }

        private void menuProfile_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile();
            f.Text = $"Form Profile";
            f.MdiParent = this;
            f.Show();
        }

        private void menuMainPage_Click(object sender, EventArgs e)
        {
            frmMainPage f = new frmMainPage();
            f.Text = $"Main Page";
            f.MdiParent = this;
            f.Show();
        }

        private void menuAdminPage_Click(object sender, EventArgs e)
        {
            frmAdminPage f = new frmAdminPage();
            f.Text = $"Admin Form";
            f.MdiParent = this;
            f.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to logout ?", "Logout",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                frmLogin f = new frmLogin();
                f.Show();
                LoginInfo.user = null;
                this.Close();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to exit ?", "Exit",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
            frmMainPage f = new frmMainPage();
            f.Text = $"Main Page";
            f.MdiParent = this;
            f.Show();
        }
    }
}
