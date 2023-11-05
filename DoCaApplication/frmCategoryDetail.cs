using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoCaApplication
{
    public partial class frmCategoryDetail : Form
    {
        public frmCategoryDetail()
        {
            InitializeComponent();
        }

        public ICategoryRepository CategoryRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        // False : Insert, True : Update
        public Category CategoryDetail { get; set; }

        private void frmCategoryDetail_Load(object sender, EventArgs e)
        {
            txtCategoryId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtCategoryId.Text = CategoryDetail.Id.ToString();
                txtCategoryName.Text = CategoryDetail.Name;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoryId.Text.Trim() == "" || txtCategoryName.Text.Trim() == "")
                {
                    MessageBox.Show("All fields are required!", "Category Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(txtCategoryId.Text) < 0)
                {
                    MessageBox.Show("ID not valid!", "Category Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var category = new Category
                    {
                        Id = int.Parse(txtCategoryId.Text),
                        Name = txtCategoryName.Text,
                    };
                    if (InsertOrUpdate == false)
                    {
                        CategoryRepository.CreateCategory(category);
                        DialogResult d;
                        d = MessageBox.Show("Create successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        CategoryRepository.UpdateCategory(category);
                        DialogResult d;
                        d = MessageBox.Show("Update successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new category" : "Update a category");
            }
        }
    }
}
