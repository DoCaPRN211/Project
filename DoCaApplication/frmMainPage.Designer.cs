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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            dgvPost = new DataGridView();
            btnCreatePost = new Button();
            btnViewPost = new Button();
            txtPost = new TextBox();
            txtPost1 = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnShowPost = new Button();
            lbBan = new Label();
            btnBookmark = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            btnSort = new Button();
            cboSort = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPost
            // 
            dgvPost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPost.Location = new Point(238, 4);
            dgvPost.Margin = new Padding(3, 4, 3, 4);
            dgvPost.Name = "dgvPost";
            dgvPost.RowHeadersWidth = 51;
            dgvPost.RowTemplate.Height = 25;
            dgvPost.Size = new Size(901, 883);
            dgvPost.TabIndex = 0;
            dgvPost.CellDoubleClick += dgvPost_CellDoubleClick;
            // 
            // btnCreatePost
            // 
            btnCreatePost.Location = new Point(27, 148);
            btnCreatePost.Margin = new Padding(3, 4, 3, 4);
            btnCreatePost.Name = "btnCreatePost";
            btnCreatePost.Size = new Size(166, 31);
            btnCreatePost.TabIndex = 2;
            btnCreatePost.Text = "Create new post";
            btnCreatePost.UseVisualStyleBackColor = true;
            btnCreatePost.Click += btnCreatePost_Click;
            // 
            // btnViewPost
            // 
            btnViewPost.Location = new Point(27, 187);
            btnViewPost.Margin = new Padding(3, 4, 3, 4);
            btnViewPost.Name = "btnViewPost";
            btnViewPost.Size = new Size(166, 31);
            btnViewPost.TabIndex = 3;
            btnViewPost.Text = "View post";
            btnViewPost.UseVisualStyleBackColor = true;
            btnViewPost.Click += btnViewPost_Click;
            // 
            // txtPost
            // 
            txtPost.Location = new Point(1241, 13);
            txtPost.Margin = new Padding(3, 4, 3, 4);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(114, 27);
            txtPost.TabIndex = 5;
            // 
            // txtPost1
            // 
            txtPost1.Location = new Point(1241, 52);
            txtPost1.Margin = new Padding(3, 4, 3, 4);
            txtPost1.Name = "txtPost1";
            txtPost1.Size = new Size(114, 27);
            txtPost1.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1193, 150);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search Posts";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1193, 185);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(162, 27);
            txtSearch.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(27, 365);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(166, 29);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh Page";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnShowPost
            // 
            btnShowPost.Location = new Point(27, 256);
            btnShowPost.Name = "btnShowPost";
            btnShowPost.Size = new Size(166, 29);
            btnShowPost.TabIndex = 10;
            btnShowPost.Text = "Show my Posts";
            btnShowPost.UseVisualStyleBackColor = true;
            btnShowPost.Click += btnShowPost_Click;
            // 
            // lbBan
            // 
            lbBan.ForeColor = Color.Red;
            lbBan.Location = new Point(27, 26);
            lbBan.Name = "lbBan";
            lbBan.Size = new Size(166, 86);
            lbBan.TabIndex = 11;
            lbBan.Text = "Notification: \r\nYou can not create or edit any posts due to being banned!";
            lbBan.Visible = false;
            // 
            // btnBookmark
            // 
            btnBookmark.Location = new Point(27, 291);
            btnBookmark.Name = "btnBookmark";
            btnBookmark.Size = new Size(166, 29);
            btnBookmark.TabIndex = 12;
            btnBookmark.Text = "Show Bookmark List";
            btnBookmark.UseVisualStyleBackColor = true;
            btnBookmark.Click += btnBookmark_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(27, 400);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(166, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close Page";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1169, 567);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(1193, 275);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(162, 29);
            btnSort.TabIndex = 15;
            btnSort.Text = "Sort Post";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(1193, 310);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(162, 28);
            cboSort.TabIndex = 16;
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 889);
            Controls.Add(cboSort);
            Controls.Add(btnSort);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnBookmark);
            Controls.Add(lbBan);
            Controls.Add(btnShowPost);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtPost1);
            Controls.Add(txtPost);
            Controls.Add(btnViewPost);
            Controls.Add(btnCreatePost);
            Controls.Add(dgvPost);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMainPage";
            Text = "frmMainPage";
            Load += frmMainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPost).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPost;
        private Button btnCreatePost;
        private Button btnViewPost;
        private TextBox txtPost;
        private TextBox txtPost1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnShowPost;
        private Label lbBan;
        private Button btnBookmark;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnSort;
        private ComboBox cboSort;
    }
}