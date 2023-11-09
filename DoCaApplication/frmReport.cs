using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoCaApplication
{
    public partial class frmReport : Form
    {
        public Post post { get; set; }
        public Comment comment { get; set; }
        IReportRepository repository = new ReportRepository();
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboReport.Text.Equals(""))
                {
                    MessageBox.Show("Enter reason to report!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var report = new Report
                    {
                        Id = Guid.NewGuid().ToString(),
                        Commentid = (comment == null) ? null : comment.Id,
                        Postid = (post == null) ? null : post.Id,
                        Userid = LoginInfo.user.Id,
                        Isactive = true,
                        Message = cboReport.Text
                    };
                    repository.AddReport(report);
                    DialogResult d;
                    d = MessageBox.Show("Report has been sent!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (d == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
