namespace DoCaApplication
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            pbConfirm = new PictureBox();
            pbNewPass = new PictureBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtConfirm = new TextBox();
            txtNewPass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 60);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 125);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(219, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(212, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 27);
            txtEmail.TabIndex = 3;
            // 
            // pbConfirm
            // 
            pbConfirm.BackColor = SystemColors.ControlLightLight;
            pbConfirm.Image = (Image)resources.GetObject("pbConfirm.Image");
            pbConfirm.Location = new Point(409, 251);
            pbConfirm.Name = "pbConfirm";
            pbConfirm.Size = new Size(20, 20);
            pbConfirm.SizeMode = PictureBoxSizeMode.StretchImage;
            pbConfirm.TabIndex = 39;
            pbConfirm.TabStop = false;
            pbConfirm.MouseDown += pbConfirm_MouseDown;
            pbConfirm.MouseUp += pbConfirm_MouseUp;
            // 
            // pbNewPass
            // 
            pbNewPass.BackColor = SystemColors.ControlLightLight;
            pbNewPass.Image = (Image)resources.GetObject("pbNewPass.Image");
            pbNewPass.Location = new Point(409, 191);
            pbNewPass.Name = "pbNewPass";
            pbNewPass.Size = new Size(20, 20);
            pbNewPass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewPass.TabIndex = 38;
            pbNewPass.TabStop = false;
            pbNewPass.MouseDown += pbNewPass_MouseDown;
            pbNewPass.MouseUp += pbNewPass_MouseUp;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(291, 321);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(147, 321);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(219, 247);
            txtConfirm.Margin = new Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(212, 27);
            txtConfirm.TabIndex = 35;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(219, 187);
            txtNewPass.Margin = new Padding(3, 4, 3, 4);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(212, 27);
            txtNewPass.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 251);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 33;
            label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 191);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 32;
            label4.Text = "New Password:";
            // 
            // frmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 391);
            Controls.Add(pbConfirm);
            Controls.Add(pbNewPass);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirm);
            Controls.Add(txtNewPass);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmForgotPassword";
            Text = "frmForgotPassword";
            Load += frmForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pbConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private PictureBox pbConfirm;
        private PictureBox pbNewPass;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtConfirm;
        private TextBox txtNewPass;
        private Label label3;
        private Label label4;
    }
}