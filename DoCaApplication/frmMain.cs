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

            //mainMenu
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, menuWindow });
            mainMenu.MdiWindowListItem = menuWindow;

            //menuFile
            if (LoginInfo.user.Role.Equals("ADMIN"))
            {
                menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuProfile, menuMainPage, menuAdminPage, menuLogout, menuExit });
            }
            else
            {
                menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuProfile, menuMainPage, menuLogout, menuExit });
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

        }

        private void menuAdminPage_Click(object sender, EventArgs e)
        {

        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            LoginInfo.user = null;
            this.Close();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }
    }
}
