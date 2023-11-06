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
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnShowPost = new Button();
            lbBan = new Label();
            btnBookmark = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPost).BeginInit();
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
            btnCreatePost.Location = new Point(27, 95);
            btnCreatePost.Margin = new Padding(3, 4, 3, 4);
            btnCreatePost.Name = "btnCreatePost";
            btnCreatePost.Size = new Size(138, 31);
            btnCreatePost.TabIndex = 2;
            btnCreatePost.Text = "Create new post";
            btnCreatePost.UseVisualStyleBackColor = true;
            btnCreatePost.Click += btnCreatePost_Click;
            // 
            // btnViewPost
            // 
            btnViewPost.Location = new Point(27, 133);
            btnViewPost.Margin = new Padding(3, 4, 3, 4);
            btnViewPost.Name = "btnViewPost";
            btnViewPost.Size = new Size(86, 31);
            btnViewPost.TabIndex = 3;
            btnViewPost.Text = "View post";
            btnViewPost.UseVisualStyleBackColor = true;
            btnViewPost.Click += btnViewPost_Click;
            // 
            // txtPost
            // 
            txtPost.Location = new Point(1241, 4);
            txtPost.Margin = new Padding(3, 4, 3, 4);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(114, 27);
            txtPost.TabIndex = 5;
            // 
            // txtPost1
            // 
            txtPost1.Location = new Point(1241, 43);
            txtPost1.Margin = new Padding(3, 4, 3, 4);
            txtPost1.Name = "txtPost1";
            txtPost1.Size = new Size(114, 27);
            txtPost1.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(32, 244);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(32, 279);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(133, 27);
            txtSearch.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(32, 351);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnShowPost
            // 
            btnShowPost.Location = new Point(32, 438);
            btnShowPost.Name = "btnShowPost";
            btnShowPost.Size = new Size(161, 29);
            btnShowPost.TabIndex = 10;
            btnShowPost.Text = "Show my Posts";
            btnShowPost.UseVisualStyleBackColor = true;
            btnShowPost.Click += btnShowPost_Click;
            // 
            // lbBan
            // 
            lbBan.Location = new Point(27, 28);
            lbBan.Name = "lbBan";
            lbBan.Size = new Size(166, 63);
            lbBan.TabIndex = 11;
            lbBan.Text = "You can not create any posts due to being banned!";
            lbBan.Visible = false;
            // 
            // btnBookmark
            // 
            btnBookmark.Location = new Point(32, 508);
            btnBookmark.Name = "btnBookmark";
            btnBookmark.Size = new Size(161, 29);
            btnBookmark.TabIndex = 12;
            btnBookmark.Text = "Show Bookmark List";
            btnBookmark.UseVisualStyleBackColor = true;
            btnBookmark.Click += btnBookmark_Click;
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 889);
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
    }
}