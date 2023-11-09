namespace DoCaApplication
{
    partial class frmProfile
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            dtpDoB = new DateTimePicker();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGender = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnEdit = new Button();
            btnClose = new Button();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            btnCancel = new Button();
            btnSave = new Button();
            btnChangePass = new Button();
            pbPass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPass).BeginInit();
            SuspendLayout();
            // 
            // dtpDoB
            // 
            dtpDoB.Enabled = false;
            dtpDoB.Format = DateTimePickerFormat.Short;
            dtpDoB.Location = new Point(199, 280);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(273, 27);
            dtpDoB.TabIndex = 37;
            // 
            // txtFullname
            // 
            txtFullname.Enabled = false;
            txtFullname.Location = new Point(199, 171);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(273, 27);
            txtFullname.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(199, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 27);
            txtEmail.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(199, 393);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(122, 27);
            txtPassword.TabIndex = 39;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(199, 117);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(273, 27);
            txtUsername.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(213, 47);
            label7.Name = "label7";
            label7.Size = new Size(141, 31);
            label7.TabIndex = 32;
            label7.Text = "Your Profile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 400);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 31;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 344);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 30;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 288);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 29;
            label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 232);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 28;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 177);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 27;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 124);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 26;
            label1.Text = "User Name:";
            // 
            // txtGender
            // 
            txtGender.Enabled = false;
            txtGender.Location = new Point(199, 333);
            txtGender.Margin = new Padding(3, 4, 3, 4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(273, 27);
            txtGender.TabIndex = 38;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(153, 481);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(121, 40);
            btnEdit.TabIndex = 41;
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(318, 481);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 40);
            btnClose.TabIndex = 42;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(288, 335);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(78, 24);
            rbtnFemale.TabIndex = 44;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            rbtnFemale.Visible = false;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Checked = true;
            rbtnMale.Location = new Point(199, 335);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 43;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            rbtnMale.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(235, 481);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 40);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(119, 481);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 40);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.Location = new Point(328, 388);
            btnChangePass.Margin = new Padding(3, 4, 3, 4);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(144, 36);
            btnChangePass.TabIndex = 47;
            btnChangePass.Text = "Change Password";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // pbPass
            // 
            pbPass.BackColor = SystemColors.ControlLightLight;
            pbPass.Image = (Image)resources.GetObject("pbPass.Image");
            pbPass.Location = new Point(299, 395);
            pbPass.Name = "pbPass";
            pbPass.Size = new Size(22, 24);
            pbPass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPass.TabIndex = 48;
            pbPass.TabStop = false;
            pbPass.MouseDown += pbPass_MouseDown;
            pbPass.MouseUp += pbPass_MouseUp;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 599);
            Controls.Add(pbPass);
            Controls.Add(btnChangePass);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(rbtnFemale);
            Controls.Add(rbtnMale);
            Controls.Add(btnClose);
            Controls.Add(btnEdit);
            Controls.Add(txtGender);
            Controls.Add(dtpDoB);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProfile";
            Text = "frmProfile";
            Load += frmProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pbPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDoB;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGender;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnEdit;
        private Button btnClose;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Button btnCancel;
        private Button btnSave;
        private Button btnChangePass;
        private PictureBox pbPass;
    }
}