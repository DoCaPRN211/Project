namespace DoCaApplication
{
    partial class frmCategoryDetail
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
            btnCancel = new Button();
            txtCategoryName = new TextBox();
            txtCategoryId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(304, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(188, 160);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(200, 27);
            txtCategoryName.TabIndex = 13;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(188, 79);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(97, 27);
            txtCategoryId.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 163);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 12;
            label2.Text = "Category Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 82);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 11;
            label1.Text = "Category ID:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 235);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmCategoryDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 322);
            Controls.Add(btnCancel);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "frmCategoryDetail";
            Text = "frmCategoryDetail";
            Load += frmCategoryDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private TextBox txtCategoryName;
        private TextBox txtCategoryId;
        private Label label2;
        private Label label1;
        private Button btnSave;
    }
}