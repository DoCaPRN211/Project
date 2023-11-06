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
            ((System.ComponentModel.ISupportInitialize)dgvComment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 47);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 96);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Content";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 363);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Comments:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(207, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(402, 23);
            txtTitle.TabIndex = 4;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(207, 93);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(402, 237);
            txtContent.TabIndex = 5;
            // 
            // dgvComment
            // 
            dgvComment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComment.Location = new Point(207, 363);
            dgvComment.Name = "dgvComment";
            dgvComment.RowTemplate.Height = 25;
            dgvComment.Size = new Size(402, 221);
            dgvComment.TabIndex = 6;
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(647, 455);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(116, 23);
            btnAddComment.TabIndex = 7;
            btnAddComment.Text = "Add Comment";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // btnViewComment
            // 
            btnViewComment.Location = new Point(647, 484);
            btnViewComment.Name = "btnViewComment";
            btnViewComment.Size = new Size(116, 23);
            btnViewComment.TabIndex = 8;
            btnViewComment.Text = "View Comment";
            btnViewComment.UseVisualStyleBackColor = true;
            btnViewComment.Click += btnViewComment_Click;
            // 
            // txtCreateTime
            // 
            txtCreateTime.Location = new Point(688, 12);
            txtCreateTime.Name = "txtCreateTime";
            txtCreateTime.Size = new Size(100, 23);
            txtCreateTime.TabIndex = 9;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(688, 39);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(100, 23);
            txtComment.TabIndex = 10;
            // 
            // btnLike
            // 
            btnLike.Location = new Point(647, 513);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(116, 23);
            btnLike.TabIndex = 11;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(688, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // btnEditPost
            // 
            btnEditPost.Location = new Point(647, 416);
            btnEditPost.Name = "btnEditPost";
            btnEditPost.Size = new Size(75, 23);
            btnEditPost.TabIndex = 13;
            btnEditPost.Text = "Edit Post";
            btnEditPost.UseVisualStyleBackColor = true;
            btnEditPost.Click += btnEditPost_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(647, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete this Post";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmViewPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
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
    }
}