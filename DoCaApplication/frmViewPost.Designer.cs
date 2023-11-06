namespace DoCaApplication
{
    partial class frmViewPost
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtContent = new TextBox();
            dgvComment = new DataGridView();
            btnAddComment = new Button();
            btnViewComment = new Button();
            txtCreateTime = new TextBox();
            txtComment = new TextBox();
            btnLike = new Button();
            txtId = new TextBox();
            btnEditPost = new Button();
            btnDelete = new Button();
            lbBan = new Label();
            btnBookmark = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvComment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 63);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 128);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Content";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 484);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Comments:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(237, 59);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(459, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(237, 124);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(459, 315);
            txtContent.TabIndex = 5;
            // 
            // dgvComment
            // 
            dgvComment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComment.Location = new Point(237, 484);
            dgvComment.Margin = new Padding(3, 4, 3, 4);
            dgvComment.Name = "dgvComment";
            dgvComment.RowHeadersWidth = 51;
            dgvComment.RowTemplate.Height = 25;
            dgvComment.Size = new Size(459, 295);
            dgvComment.TabIndex = 6;
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(739, 607);
            btnAddComment.Margin = new Padding(3, 4, 3, 4);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(133, 31);
            btnAddComment.TabIndex = 7;
            btnAddComment.Text = "Add Comment";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // btnViewComment
            // 
            btnViewComment.Location = new Point(739, 645);
            btnViewComment.Margin = new Padding(3, 4, 3, 4);
            btnViewComment.Name = "btnViewComment";
            btnViewComment.Size = new Size(133, 31);
            btnViewComment.TabIndex = 8;
            btnViewComment.Text = "View Comment";
            btnViewComment.UseVisualStyleBackColor = true;
            btnViewComment.Click += btnViewComment_Click;
            // 
            // txtCreateTime
            // 
            txtCreateTime.Location = new Point(786, 16);
            txtCreateTime.Margin = new Padding(3, 4, 3, 4);
            txtCreateTime.Name = "txtCreateTime";
            txtCreateTime.Size = new Size(114, 27);
            txtCreateTime.TabIndex = 9;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(786, 52);
            txtComment.Margin = new Padding(3, 4, 3, 4);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(114, 27);
            txtComment.TabIndex = 10;
            // 
            // btnLike
            // 
            btnLike.Location = new Point(739, 684);
            btnLike.Margin = new Padding(3, 4, 3, 4);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(133, 31);
            btnLike.TabIndex = 11;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(786, 91);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 12;
            // 
            // btnEditPost
            // 
            btnEditPost.Location = new Point(739, 555);
            btnEditPost.Margin = new Padding(3, 4, 3, 4);
            btnEditPost.Name = "btnEditPost";
            btnEditPost.Size = new Size(86, 31);
            btnEditPost.TabIndex = 13;
            btnEditPost.Text = "Edit Post";
            btnEditPost.UseVisualStyleBackColor = true;
            btnEditPost.Click += btnEditPost_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(739, 516);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete this Post";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbBan
            // 
            lbBan.Location = new Point(12, 234);
            lbBan.Name = "lbBan";
            lbBan.Size = new Size(166, 63);
            lbBan.TabIndex = 15;
            lbBan.Text = "You can not make any comments due to being banned!";
            lbBan.Visible = false;
            // 
            // btnBookmark
            // 
            btnBookmark.Location = new Point(739, 311);
            btnBookmark.Name = "btnBookmark";
            btnBookmark.Size = new Size(161, 29);
            btnBookmark.TabIndex = 16;
            btnBookmark.Text = "Save as Bookmark";
            btnBookmark.UseVisualStyleBackColor = true;
            btnBookmark.Click += btnBookmark_Click;
            // 
            // frmViewPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 820);
            Controls.Add(btnBookmark);
            Controls.Add(lbBan);
            Controls.Add(btnDelete);
            Controls.Add(btnEditPost);
            Controls.Add(txtId);
            Controls.Add(btnLike);
            Controls.Add(txtComment);
            Controls.Add(txtCreateTime);
            Controls.Add(btnViewComment);
            Controls.Add(btnAddComment);
            Controls.Add(dgvComment);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmViewPost";
            Text = "frmViewPost";
            Load += frmViewPost_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtContent;
        private DataGridView dgvComment;
        private Button btnAddComment;
        private Button btnViewComment;
        private TextBox txtCreateTime;
        private TextBox txtComment;
        private Button btnLike;
        private TextBox txtId;
        private Button btnEditPost;
        private Button btnDelete;
        private Label lbBan;
        private Button btnBookmark;
    }
}