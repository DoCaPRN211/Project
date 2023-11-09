namespace DoCaApplication
{
    partial class frmReport
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
            cboReport = new ComboBox();
            btnReport = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cboReport
            // 
            cboReport.FormattingEnabled = true;
            cboReport.Items.AddRange(new object[] { "Spam", "Organizing or promoting violence", "Illegal Activities", "Spreading Misinformation", "Hate group or contains hate speech", "Sexually explicit content", "Racism, sexism, homophobia or other discrimination", "Violation of someone's privacy", "National politics or religion", "Irrelevant or annoying" });
            cboReport.Location = new Point(129, 73);
            cboReport.Name = "cboReport";
            cboReport.Size = new Size(377, 28);
            cboReport.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(190, 151);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 29);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(343, 151);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 76);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Reason:";
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 244);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnReport);
            Controls.Add(cboReport);
            Name = "frmReport";
            Text = "frmReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboReport;
        private Button btnReport;
        private Button btnCancel;
        private Label label1;
    }
}