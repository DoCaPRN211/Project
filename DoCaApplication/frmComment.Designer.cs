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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 84);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Comment:";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(269, 71);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(222, 95);
            txtComment.TabIndex = 1;
            // 
            // btnLike
            // 
            btnLike.Location = new Point(235, 236);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(75, 23);
            btnLike.TabIndex = 2;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(244, 236);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(75, 23);
            btnAddComment.TabIndex = 3;
            btnAddComment.Text = "Add Comment";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(441, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(342, 236);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(308, 279);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete this Comment";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCancel);
            Controls.Add(btnAddComment);
            Controls.Add(btnLike);
            Controls.Add(txtComment);
            Controls.Add(label1);
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
    }
}