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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCurPass = new TextBox();
            txtNewPass = new TextBox();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            pbCurrentPass = new PictureBox();
            pbNewPass = new PictureBox();
            pbConfirm = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCurrentPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirm).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 61);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Current Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 120);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "New Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 180);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password:";
            // 
            // txtCurPass
            // 
            txtCurPass.Location = new Point(189, 57);
            txtCurPass.Margin = new Padding(3, 4, 3, 4);
            txtCurPass.Name = "txtCurPass";
            txtCurPass.PasswordChar = '*';
            txtCurPass.Size = new Size(212, 27);
            txtCurPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(189, 116);
            txtNewPass.Margin = new Padding(3, 4, 3, 4);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(212, 27);
            txtNewPass.TabIndex = 4;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(189, 176);
            txtConfirm.Margin = new Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(212, 27);
            txtConfirm.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(118, 244);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(262, 244);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pbCurrentPass
            // 
            pbCurrentPass.BackColor = SystemColors.ControlLightLight;
            pbCurrentPass.Image = (Image)resources.GetObject("pbCurrentPass.Image");
            pbCurrentPass.Location = new Point(379, 61);
            pbCurrentPass.Name = "pbCurrentPass";
            pbCurrentPass.Size = new Size(20, 20);
            pbCurrentPass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCurrentPass.TabIndex = 29;
            pbCurrentPass.TabStop = false;
            pbCurrentPass.MouseDown += pbCurrentPass_MouseDown;
            pbCurrentPass.MouseUp += pbCurrentPass_MouseUp;
            // 
            // pbNewPass
            // 
            pbNewPass.BackColor = SystemColors.ControlLightLight;
            pbNewPass.Image = (Image)resources.GetObject("pbNewPass.Image");
            pbNewPass.Location = new Point(379, 120);
            pbNewPass.Name = "pbNewPass";
            pbNewPass.Size = new Size(20, 20);
            pbNewPass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewPass.TabIndex = 30;
            pbNewPass.TabStop = false;
            pbNewPass.MouseDown += pbNewPass_MouseDown;
            pbNewPass.MouseUp += pbNewPass_MouseUp;
            // 
            // pbConfirm
            // 
            pbConfirm.BackColor = SystemColors.ControlLightLight;
            pbConfirm.Image = (Image)resources.GetObject("pbConfirm.Image");
            pbConfirm.Location = new Point(379, 180);
            pbConfirm.Name = "pbConfirm";
            pbConfirm.Size = new Size(20, 20);
            pbConfirm.SizeMode = PictureBoxSizeMode.StretchImage;
            pbConfirm.TabIndex = 31;
            pbConfirm.TabStop = false;
            pbConfirm.MouseDown += pbConfirm_MouseDown;
            pbConfirm.MouseUp += pbConfirm_MouseUp;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 308);
            Controls.Add(pbConfirm);
            Controls.Add(pbNewPass);
            Controls.Add(pbCurrentPass);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirm);
            Controls.Add(txtNewPass);
            Controls.Add(txtCurPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmResetPassword";
            Text = "frmResetPassword";
            Load += frmResetPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pbCurrentPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirm).EndInit();
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
        private PictureBox pbCurrentPass;
        private PictureBox pbNewPass;
        private PictureBox pbConfirm;
    }
}