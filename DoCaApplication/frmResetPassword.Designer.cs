namespace DoCaApplication
{
    partial class frmResetPassword
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
            txtCurPass = new TextBox();
            txtNewPass = new TextBox();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 46);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Current Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 90);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "New Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 135);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password:";
            // 
            // txtCurPass
            // 
            txtCurPass.Location = new Point(165, 43);
            txtCurPass.Name = "txtCurPass";
            txtCurPass.Size = new Size(186, 23);
            txtCurPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(165, 87);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(186, 23);
            txtNewPass.TabIndex = 4;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(165, 132);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(186, 23);
            txtConfirm.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 183);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(229, 183);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 231);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirm);
            Controls.Add(txtNewPass);
            Controls.Add(txtCurPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmResetPassword";
            Text = "frmResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCurPass;
        private TextBox txtNewPass;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnCancel;
    }
}