namespace DoCaApplication
{
    partial class frmComment
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
            txtComment = new TextBox();
            btnLike = new Button();
            btnAddComment = new Button();
            btnCancel = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtBy = new TextBox();
            lbBy = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 80);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Comment:";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(188, 80);
            txtComment.Margin = new Padding(3, 4, 3, 4);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(257, 125);
            txtComment.TabIndex = 2;
            // 
            // btnLike
            // 
            btnLike.Location = new Point(204, 240);
            btnLike.Margin = new Padding(3, 4, 3, 4);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(86, 31);
            btnLike.TabIndex = 1;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(204, 240);
            btnAddComment.Margin = new Padding(3, 4, 3, 4);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(86, 31);
            btnAddComment.TabIndex = 3;
            btnAddComment.Text = "Add Comment";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(344, 240);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(204, 279);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(344, 279);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBy
            // 
            txtBy.Location = new Point(188, 25);
            txtBy.Name = "txtBy";
            txtBy.ReadOnly = true;
            txtBy.Size = new Size(125, 27);
            txtBy.TabIndex = 7;
            // 
            // lbBy
            // 
            lbBy.AutoSize = true;
            lbBy.Location = new Point(127, 28);
            lbBy.Name = "lbBy";
            lbBy.Size = new Size(28, 20);
            lbBy.TabIndex = 8;
            lbBy.Text = "By:";
            // 
            // frmComment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 383);
            Controls.Add(lbBy);
            Controls.Add(txtBy);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCancel);
            Controls.Add(btnAddComment);
            Controls.Add(btnLike);
            Controls.Add(txtComment);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmComment";
            Text = "frmComment";
            Load += frmComment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtComment;
        private Button btnLike;
        private Button btnAddComment;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtBy;
        private Label lbBy;
    }
}