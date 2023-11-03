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
            SuspendLayout();
            // 
            // dtpDoB
            // 
            dtpDoB.Enabled = false;
            dtpDoB.Format = DateTimePickerFormat.Short;
            dtpDoB.Location = new Point(174, 210);
            dtpDoB.Margin = new Padding(3, 2, 3, 2);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(226, 23);
            dtpDoB.TabIndex = 37;
            // 
            // txtFullname
            // 
            txtFullname.Enabled = false;
            txtFullname.Location = new Point(174, 128);
            txtFullname.Margin = new Padding(3, 2, 3, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(226, 23);
            txtFullname.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(174, 169);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(226, 23);
            txtEmail.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(174, 295);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(107, 23);
            txtPassword.TabIndex = 39;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(174, 88);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(226, 23);
            txtUsername.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(186, 35);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 32;
            label7.Text = "Your Profile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 300);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 31;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 258);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 30;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 216);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 29;
            label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 174);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 28;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 27;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 93);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 26;
            label1.Text = "User Name:";
            // 
            // txtGender
            // 
            txtGender.Enabled = false;
            txtGender.Location = new Point(174, 250);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(226, 23);
            txtGender.TabIndex = 38;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(134, 361);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 30);
            btnEdit.TabIndex = 41;
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(278, 361);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 30);
            btnClose.TabIndex = 42;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(252, 251);
            rbtnFemale.Margin = new Padding(3, 2, 3, 2);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(63, 19);
            rbtnFemale.TabIndex = 44;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            rbtnFemale.Visible = false;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Checked = true;
            rbtnMale.Location = new Point(174, 251);
            rbtnMale.Margin = new Padding(3, 2, 3, 2);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(51, 19);
            rbtnMale.TabIndex = 43;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            rbtnMale.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(206, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(104, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.Location = new Point(287, 292);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(113, 30);
            btnChangePass.TabIndex = 47;
            btnChangePass.Text = "Change Password";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 449);
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
            Name = "frmProfile";
            Text = "frmProfile";
            Load += frmProfile_Load;
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
    }
}