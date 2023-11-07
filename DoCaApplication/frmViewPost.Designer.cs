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
            btnClose = new Button();
            lbBy = new Label();
            txtBy = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvComment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 85);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 143);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Content:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 439);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Comments:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(237, 78);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(459, 27);
            txtTitle.TabIndex = 11;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(237, 143);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(459, 256);
            txtContent.TabIndex = 5;
            // 
            // dgvComment
            // 
            dgvComment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComment.Location = new Point(237, 439);
            dgvComment.Margin = new Padding(3, 4, 3, 4);
            dgvComment.Name = "dgvComment";
            dgvComment.RowHeadersWidth = 51;
            dgvComment.RowTemplate.Height = 25;
            dgvComment.Size = new Size(459, 295);
            dgvComment.TabIndex = 6;
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(756, 543);
            btnAddComment.Margin = new Padding(3, 4, 3, 4);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(144, 31);
            btnAddComment.TabIndex = 7;
            btnAddComment.Text = "Add Comment";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // btnViewComment
            // 
            btnViewComment.Location = new Point(756, 504);
            btnViewComment.Margin = new Padding(3, 4, 3, 4);
            btnViewComment.Name = "btnViewComment";
            btnViewComment.Size = new Size(144, 31);
            btnViewComment.TabIndex = 8;
            btnViewComment.Text = "View Comment";
            btnViewComment.UseVisualStyleBackColor = true;
            btnViewComment.Click += btnViewComment_Click;
            // 
            // txtCreateTime
            // 
            txtCreateTime.Location = new Point(786, 35);
            txtCreateTime.Margin = new Padding(3, 4, 3, 4);
            txtCreateTime.Name = "txtCreateTime";
            txtCreateTime.Size = new Size(114, 27);
            txtCreateTime.TabIndex = 9;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(786, 71);
            txtComment.Margin = new Padding(3, 4, 3, 4);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(114, 27);
            txtComment.TabIndex = 10;
            // 
            // btnLike
            // 
            btnLike.Location = new Point(756, 439);
            btnLike.Margin = new Padding(3, 4, 3, 4);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(144, 31);
            btnLike.TabIndex = 4;
            btnLike.Text = "Like Post";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(786, 110);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 12;
            // 
            // btnEditPost
            // 
            btnEditPost.Location = new Point(756, 641);
            btnEditPost.Margin = new Padding(3, 4, 3, 4);
            btnEditPost.Name = "btnEditPost";
            btnEditPost.Size = new Size(144, 31);
            btnEditPost.TabIndex = 13;
            btnEditPost.Text = "Edit Post";
            btnEditPost.UseVisualStyleBackColor = true;
            btnEditPost.Click += btnEditPost_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(756, 602);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete Post";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbBan
            // 
            lbBan.ForeColor = Color.Red;
            lbBan.Location = new Point(22, 253);
            lbBan.Name = "lbBan";
            lbBan.Size = new Size(166, 92);
            lbBan.TabIndex = 15;
            lbBan.Text = "Notification: \r\nYou can not make any changes in comments due to being banned!";
            lbBan.Visible = false;
            // 
            // btnBookmark
            // 
            btnBookmark.Location = new Point(756, 289);
            btnBookmark.Name = "btnBookmark";
            btnBookmark.Size = new Size(161, 29);
            btnBookmark.TabIndex = 16;
            btnBookmark.Text = "Save as Bookmark";
            btnBookmark.UseVisualStyleBackColor = true;
            btnBookmark.Click += btnBookmark_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(756, 705);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 29);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close Post";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbBy
            // 
            lbBy.AutoSize = true;
            lbBy.Location = new Point(138, 25);
            lbBy.Name = "lbBy";
            lbBy.Size = new Size(76, 20);
            lbBy.TabIndex = 18;
            lbBy.Text = "Posted By:";
            // 
            // txtBy
            // 
            txtBy.Location = new Point(237, 22);
            txtBy.Name = "txtBy";
            txtBy.ReadOnly = true;
            txtBy.Size = new Size(149, 27);
            txtBy.TabIndex = 19;
            // 
            // frmViewPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 757);
            Controls.Add(txtBy);
            Controls.Add(lbBy);
            Controls.Add(btnClose);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnClose;
        private Label lbBy;
        private TextBox txtBy;
    }
}