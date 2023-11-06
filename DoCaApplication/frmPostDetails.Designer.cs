namespace DoCaApplication
{
    partial class frmPostDetails
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
            label4 = new Label();
            txtTitle = new TextBox();
            txtContent = new TextBox();
            cboCate = new ComboBox();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 97);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 135);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Content:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 283);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(202, 26);
            label4.Name = "label4";
            label4.Size = new Size(215, 32);
            label4.TabIndex = 3;
            label4.Text = "Create A New Post";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(164, 94);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(304, 23);
            txtTitle.TabIndex = 4;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(164, 135);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(304, 130);
            txtContent.TabIndex = 5;
            // 
            // cboCate
            // 
            cboCate.FormattingEnabled = true;
            cboCate.Location = new Point(164, 283);
            cboCate.Name = "cboCate";
            cboCate.Size = new Size(304, 23);
            cboCate.TabIndex = 6;
            cboCate.SelectedIndexChanged += cboCate_SelectedIndexChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(202, 364);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(321, 364);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmPostDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(cboCate);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPostDetails";
            Text = "frmCreatePost";
            Load += frmPostDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private TextBox txtContent;
        private ComboBox cboCate;
        private Button btnCreate;
        private Button btnCancel;
    }
}