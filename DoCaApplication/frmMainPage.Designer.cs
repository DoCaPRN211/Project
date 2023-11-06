namespace DoCaApplication
{
    partial class frmMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPost = new DataGridView();
            btnCreatePost = new Button();
            btnViewPost = new Button();
            txtPost = new TextBox();
            txtPost1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPost).BeginInit();
            SuspendLayout();
            // 
            // dgvPost
            // 
            dgvPost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPost.Location = new Point(208, 3);
            dgvPost.Name = "dgvPost";
            dgvPost.RowTemplate.Height = 25;
            dgvPost.Size = new Size(788, 662);
            dgvPost.TabIndex = 0;
            dgvPost.CellDoubleClick += dgvPost_CellDoubleClick;
            // 
            // btnCreatePost
            // 
            btnCreatePost.Location = new Point(24, 71);
            btnCreatePost.Name = "btnCreatePost";
            btnCreatePost.Size = new Size(121, 23);
            btnCreatePost.TabIndex = 2;
            btnCreatePost.Text = "Create new post";
            btnCreatePost.UseVisualStyleBackColor = true;
            btnCreatePost.Click += btnCreatePost_Click;
            // 
            // btnViewPost
            // 
            btnViewPost.Location = new Point(24, 100);
            btnViewPost.Name = "btnViewPost";
            btnViewPost.Size = new Size(75, 23);
            btnViewPost.TabIndex = 3;
            btnViewPost.Text = "View post";
            btnViewPost.UseVisualStyleBackColor = true;
            btnViewPost.Click += btnViewPost_Click;
            // 
            // txtPost
            // 
            txtPost.Location = new Point(1086, 3);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(100, 23);
            txtPost.TabIndex = 5;
            // 
            // txtPost1
            // 
            txtPost1.Location = new Point(1086, 32);
            txtPost1.Name = "txtPost1";
            txtPost1.Size = new Size(100, 23);
            txtPost1.TabIndex = 6;
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 667);
            Controls.Add(txtPost1);
            Controls.Add(txtPost);
            Controls.Add(btnViewPost);
            Controls.Add(btnCreatePost);
            Controls.Add(dgvPost);
            Name = "frmMainPage";
            Text = "frmMainPage";
            Load += frmMainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPost;
        private Button btnCreatePost;
        private Button btnViewPost;
        private TextBox txtPost;
        private TextBox txtPost1;
    }
}