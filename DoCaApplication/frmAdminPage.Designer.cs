namespace DoCaApplication
{
    partial class frmAdminPage
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
            dgvAdmin = new DataGridView();
            btnShowMembers = new Button();
            label1 = new Label();
            btnClose = new Button();
            txtMemberId = new TextBox();
            txtEmail = new TextBox();
            txtGender = new TextBox();
            txtBan = new TextBox();
            txtDoB = new TextBox();
            txtActive = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtFullname = new TextBox();
            txtSearch = new TextBox();
            btnSearchName = new Button();
            btnSearchEmail = new Button();
            btnActive = new Button();
            btnBan = new Button();
            btnShowBanned = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnViewCategory = new Button();
            btnCreateCategory = new Button();
            btnUpdateCategory = new Button();
            txtCategoryId = new TextBox();
            txtCategoryName = new TextBox();
            btnShowPostReport = new Button();
            btnShowCommentReport = new Button();
            txtReportId = new TextBox();
            btnView = new Button();
            btnDeleteReport = new Button();
            cboReport = new ComboBox();
            txtReportUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            SuspendLayout();
            // 
            // dgvAdmin
            // 
            dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.Location = new Point(12, 235);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.RowHeadersWidth = 51;
            dgvAdmin.RowTemplate.Height = 29;
            dgvAdmin.Size = new Size(1177, 481);
            dgvAdmin.TabIndex = 0;
            // 
            // btnShowMembers
            // 
            btnShowMembers.Location = new Point(12, 111);
            btnShowMembers.Name = "btnShowMembers";
            btnShowMembers.Size = new Size(162, 29);
            btnShowMembers.TabIndex = 1;
            btnShowMembers.Text = "Show Members";
            btnShowMembers.UseVisualStyleBackColor = true;
            btnShowMembers.Click += btnShowMembers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(571, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 38);
            label1.TabIndex = 2;
            label1.Text = "Admin Page";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 181);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(1385, 227);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(172, 27);
            txtMemberId.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1385, 448);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(172, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(1385, 566);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(172, 27);
            txtGender.TabIndex = 6;
            txtGender.TextChanged += txtGender_TextChanged;
            // 
            // txtBan
            // 
            txtBan.Location = new Point(1385, 679);
            txtBan.Name = "txtBan";
            txtBan.ReadOnly = true;
            txtBan.Size = new Size(172, 27);
            txtBan.TabIndex = 7;
            // 
            // txtDoB
            // 
            txtDoB.Location = new Point(1385, 505);
            txtDoB.Name = "txtDoB";
            txtDoB.ReadOnly = true;
            txtDoB.Size = new Size(172, 27);
            txtDoB.TabIndex = 8;
            // 
            // txtActive
            // 
            txtActive.Location = new Point(1385, 623);
            txtActive.Name = "txtActive";
            txtActive.ReadOnly = true;
            txtActive.Size = new Size(172, 27);
            txtActive.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(1385, 282);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(172, 27);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1385, 338);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(172, 27);
            txtPassword.TabIndex = 11;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(1385, 391);
            txtFullname.Name = "txtFullname";
            txtFullname.ReadOnly = true;
            txtFullname.Size = new Size(172, 27);
            txtFullname.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1402, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 27);
            txtSearch.TabIndex = 13;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(1402, 69);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(112, 29);
            btnSearchName.TabIndex = 14;
            btnSearchName.Text = "Username";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // btnSearchEmail
            // 
            btnSearchEmail.Location = new Point(1402, 104);
            btnSearchEmail.Name = "btnSearchEmail";
            btnSearchEmail.Size = new Size(112, 29);
            btnSearchEmail.TabIndex = 15;
            btnSearchEmail.Text = "Email";
            btnSearchEmail.UseVisualStyleBackColor = true;
            btnSearchEmail.Click += btnSearchEmail_Click;
            // 
            // btnActive
            // 
            btnActive.Location = new Point(12, 146);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(162, 29);
            btnActive.TabIndex = 16;
            btnActive.Text = "Delete Member";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // btnBan
            // 
            btnBan.Location = new Point(207, 146);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(198, 29);
            btnBan.TabIndex = 17;
            btnBan.Text = "Change Banned Status";
            btnBan.UseVisualStyleBackColor = true;
            btnBan.Click += btnBan_Click;
            // 
            // btnShowBanned
            // 
            btnShowBanned.Location = new Point(207, 111);
            btnShowBanned.Name = "btnShowBanned";
            btnShowBanned.Size = new Size(198, 29);
            btnShowBanned.TabIndex = 18;
            btnShowBanned.Text = "Show Banned Members";
            btnShowBanned.UseVisualStyleBackColor = true;
            btnShowBanned.Click += btnShowBanned_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1250, 234);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 19;
            label2.Text = "Member ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1250, 289);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 21;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1250, 345);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 23;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1250, 398);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 25;
            label5.Text = "Fullname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1250, 455);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 27;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1250, 512);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 29;
            label7.Text = "Date of Birth:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1250, 573);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 31;
            label8.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1250, 630);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 33;
            label9.Text = "Active Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1250, 686);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 35;
            label10.Text = "Banned Status:";
            // 
            // btnViewCategory
            // 
            btnViewCategory.Location = new Point(1028, 103);
            btnViewCategory.Name = "btnViewCategory";
            btnViewCategory.Size = new Size(161, 29);
            btnViewCategory.TabIndex = 36;
            btnViewCategory.Text = "View Categories";
            btnViewCategory.UseVisualStyleBackColor = true;
            btnViewCategory.Click += btnViewCategory_Click;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.Location = new Point(1028, 137);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Size = new Size(161, 29);
            btnCreateCategory.TabIndex = 37;
            btnCreateCategory.Text = "Create Category";
            btnCreateCategory.UseVisualStyleBackColor = true;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(1028, 172);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(161, 29);
            btnUpdateCategory.TabIndex = 38;
            btnUpdateCategory.Text = "Update Category";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(989, 20);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(87, 27);
            txtCategoryId.TabIndex = 39;
            txtCategoryId.Visible = false;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(1082, 20);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.ReadOnly = true;
            txtCategoryName.Size = new Size(157, 27);
            txtCategoryName.TabIndex = 40;
            txtCategoryName.Visible = false;
            // 
            // btnShowPostReport
            // 
            btnShowPostReport.Location = new Point(471, 111);
            btnShowPostReport.Name = "btnShowPostReport";
            btnShowPostReport.Size = new Size(180, 29);
            btnShowPostReport.TabIndex = 41;
            btnShowPostReport.Text = "Show Post Report";
            btnShowPostReport.UseVisualStyleBackColor = true;
            btnShowPostReport.Click += btnShowPostReport_Click;
            // 
            // btnShowCommentReport
            // 
            btnShowCommentReport.Location = new Point(657, 111);
            btnShowCommentReport.Name = "btnShowCommentReport";
            btnShowCommentReport.Size = new Size(200, 29);
            btnShowCommentReport.TabIndex = 42;
            btnShowCommentReport.Text = "Show Comment Report";
            btnShowCommentReport.UseVisualStyleBackColor = true;
            btnShowCommentReport.Click += btnShowCommentReport_Click;
            // 
            // txtReportId
            // 
            txtReportId.Location = new Point(104, 9);
            txtReportId.Name = "txtReportId";
            txtReportId.ReadOnly = true;
            txtReportId.Size = new Size(136, 27);
            txtReportId.TabIndex = 43;
            txtReportId.TextChanged += txtReportId_TextChanged;
            // 
            // btnView
            // 
            btnView.Location = new Point(863, 111);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 44;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDeleteReport
            // 
            btnDeleteReport.Location = new Point(471, 146);
            btnDeleteReport.Name = "btnDeleteReport";
            btnDeleteReport.Size = new Size(180, 29);
            btnDeleteReport.TabIndex = 45;
            btnDeleteReport.Text = "Delete Report";
            btnDeleteReport.UseVisualStyleBackColor = true;
            btnDeleteReport.Click += btnDeleteReport_Click;
            // 
            // cboReport
            // 
            cboReport.FormattingEnabled = true;
            cboReport.Location = new Point(657, 147);
            cboReport.Name = "cboReport";
            cboReport.Size = new Size(300, 28);
            cboReport.TabIndex = 46;
            // 
            // txtReportUsername
            // 
            txtReportUsername.Location = new Point(246, 9);
            txtReportUsername.Name = "txtReportUsername";
            txtReportUsername.ReadOnly = true;
            txtReportUsername.Size = new Size(125, 27);
            txtReportUsername.TabIndex = 47;
            // 
            // frmAdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 728);
            Controls.Add(txtReportUsername);
            Controls.Add(cboReport);
            Controls.Add(btnDeleteReport);
            Controls.Add(btnView);
            Controls.Add(txtReportId);
            Controls.Add(btnShowCommentReport);
            Controls.Add(btnShowPostReport);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryId);
            Controls.Add(btnUpdateCategory);
            Controls.Add(btnCreateCategory);
            Controls.Add(btnViewCategory);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnShowBanned);
            Controls.Add(btnBan);
            Controls.Add(btnActive);
            Controls.Add(btnSearchEmail);
            Controls.Add(btnSearchName);
            Controls.Add(txtSearch);
            Controls.Add(txtFullname);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtActive);
            Controls.Add(txtDoB);
            Controls.Add(txtBan);
            Controls.Add(txtGender);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberId);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(btnShowMembers);
            Controls.Add(dgvAdmin);
            Name = "frmAdminPage";
            Text = "frmAdminPage";
            Load += frmAdminPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAdmin;
        private Button btnShowMembers;
        private Label label1;
        private Button btnClose;
        private TextBox txtMemberId;
        private TextBox txtEmail;
        private TextBox txtGender;
        private TextBox txtBan;
        private TextBox txtDoB;
        private TextBox txtActive;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFullname;
        private TextBox txtSearch;
        private Button btnSearchName;
        private Button btnSearchEmail;
        private Button btnActive;
        private Button btnBan;
        private Button btnShowBanned;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnViewCategory;
        private Button btnCreateCategory;
        private Button btnUpdateCategory;
        private TextBox txtCategoryId;
        private TextBox txtCategoryName;
        private Button btnShowPostReport;
        private Button btnShowCommentReport;
        private TextBox txtReportId;
        private Button btnView;
        private Button btnDeleteReport;
        private ComboBox cboReport;
        private TextBox txtReportUsername;
    }
}