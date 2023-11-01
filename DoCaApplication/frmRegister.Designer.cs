namespace DoCaApplication
{
    partial class frmRegister
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtFullname = new TextBox();
            txtConfirm = new TextBox();
            dtpDoB = new DateTimePicker();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 121);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 175);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 230);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 285);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 341);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 398);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 10;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(187, 28);
            label7.Name = "label7";
            label7.Size = new Size(163, 31);
            label7.TabIndex = 11;
            label7.Text = "Register Form";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(218, 114);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 27);
            txtUsername.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 458);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 13;
            label8.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(218, 391);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 27);
            txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(218, 168);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(214, 27);
            txtFullname.TabIndex = 13;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(218, 451);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(214, 27);
            txtConfirm.TabIndex = 20;
            // 
            // dtpDoB
            // 
            dtpDoB.Format = DateTimePickerFormat.Short;
            dtpDoB.Location = new Point(218, 278);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(214, 27);
            dtpDoB.TabIndex = 16;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Checked = true;
            rbtnMale.Location = new Point(221, 337);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 17;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(310, 337);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(78, 24);
            rbtnFemale.TabIndex = 25;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(218, 521);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(338, 521);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 584);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(rbtnFemale);
            Controls.Add(rbtnMale);
            Controls.Add(dtpDoB);
            Controls.Add(txtConfirm);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            Text = "frmRegister";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private Label label8;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtFullname;
        private TextBox txtConfirm;
        private DateTimePicker dtpDoB;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private Button btnRegister;
        private Button btnCancel;
    }
}