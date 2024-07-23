namespace Contacts
{
    partial class frmhome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pepoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 6);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem,
            this.pepoleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationsTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.moreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moreToolStripMenuItem.Image")));
            this.moreToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(174, 84);
            this.moreToolStripMenuItem.Text = "Applications";
            this.moreToolStripMenuItem.Click += new System.EventHandler(this.moreToolStripMenuItem_Click);
            // 
            // manageApplicationsTypesToolStripMenuItem
            // 
            this.manageApplicationsTypesToolStripMenuItem.Name = "manageApplicationsTypesToolStripMenuItem";
            this.manageApplicationsTypesToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.manageApplicationsTypesToolStripMenuItem.Text = "Manage Applications Types";
            this.manageApplicationsTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // pepoleToolStripMenuItem
            // 
            this.pepoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pepoleToolStripMenuItem.Image")));
            this.pepoleToolStripMenuItem.Name = "pepoleToolStripMenuItem";
            this.pepoleToolStripMenuItem.Size = new System.Drawing.Size(131, 89);
            this.pepoleToolStripMenuItem.Text = "pepole";
            this.pepoleToolStripMenuItem.Click += new System.EventHandler(this.pepoleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem.Image")));
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(132, 89);
            this.driversToolStripMenuItem.Text = "drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(122, 89);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFORMATIONToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingsToolStripMenuItem.Image")));
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(203, 89);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // iNFORMATIONToolStripMenuItem
            // 
            this.iNFORMATIONToolStripMenuItem.Name = "iNFORMATIONToolStripMenuItem";
            this.iNFORMATIONToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.iNFORMATIONToolStripMenuItem.Text = "INFORMATION";
            this.iNFORMATIONToolStripMenuItem.Click += new System.EventHandler(this.iNFORMATIONToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.changePasswordToolStripMenuItem.Text = "change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Release Detained License 32.png");
            this.imageList1.Images.SetKeyName(1, "Release Detained License 64.png");
            this.imageList1.Images.SetKeyName(2, "Release Detained License 512.png");
            this.imageList1.Images.SetKeyName(3, "Detain 32.png");
            this.imageList1.Images.SetKeyName(4, "Detain 64.png");
            this.imageList1.Images.SetKeyName(5, "Detain 512.png");
            this.imageList1.Images.SetKeyName(6, "PersonLicenseHistory 512.png");
            this.imageList1.Images.SetKeyName(7, "PersonLicenseHistory 32.png");
            this.imageList1.Images.SetKeyName(8, "closeBlack32.png");
            this.imageList1.Images.SetKeyName(9, "CloseBlack.png");
            this.imageList1.Images.SetKeyName(10, "CloseBlack1.png");
            this.imageList1.Images.SetKeyName(11, "IconLogo.png");
            this.imageList1.Images.SetKeyName(12, "Logo Final.jpg");
            this.imageList1.Images.SetKeyName(13, "Driver Main.png");
            this.imageList1.Images.SetKeyName(14, "Delete 32 2.png");
            this.imageList1.Images.SetKeyName(15, "LicenseView 400.png");
            this.imageList1.Images.SetKeyName(16, "License View 32.png");
            this.imageList1.Images.SetKeyName(17, "Question 32.png");
            this.imageList1.Images.SetKeyName(18, "IssueDrivingLicense 32.png");
            this.imageList1.Images.SetKeyName(19, "PassedTests 32.png");
            this.imageList1.Images.SetKeyName(20, "AddAppointment 32.png");
            this.imageList1.Images.SetKeyName(21, "Count 32.png");
            this.imageList1.Images.SetKeyName(22, "Faild.png");
            this.imageList1.Images.SetKeyName(23, "WallPaper2.jpg");
            this.imageList1.Images.SetKeyName(24, "wallpaper1.jpg");
            this.imageList1.Images.SetKeyName(25, "wallpaper.jpg");
            this.imageList1.Images.SetKeyName(26, "Local Driving License 512.png");
            this.imageList1.Images.SetKeyName(27, "Local Driving License 5121.png");
            this.imageList1.Images.SetKeyName(28, "Test 32.png");
            this.imageList1.Images.SetKeyName(29, "Vision Test 32.png");
            this.imageList1.Images.SetKeyName(30, "Street Test 32.png");
            this.imageList1.Images.SetKeyName(31, "Written Test 32.png");
            this.imageList1.Images.SetKeyName(32, "Written Test 32 Sechdule.png");
            this.imageList1.Images.SetKeyName(33, "Schedule Test 512.png");
            this.imageList1.Images.SetKeyName(34, "Schedule Test 32.png");
            this.imageList1.Images.SetKeyName(35, "LocalDriving License.png");
            this.imageList1.Images.SetKeyName(36, "Manage Applications 32.png");
            this.imageList1.Images.SetKeyName(37, "Manage Applications 64.png");
            this.imageList1.Images.SetKeyName(38, "Notes 32.png");
            this.imageList1.Images.SetKeyName(39, "driving-test 512.png");
            this.imageList1.Images.SetKeyName(40, "Written Test 512.png");
            this.imageList1.Images.SetKeyName(41, "Vision 512.png");
            this.imageList1.Images.SetKeyName(42, "Test Type 64.png");
            this.imageList1.Images.SetKeyName(43, "TestType 32.png");
            this.imageList1.Images.SetKeyName(44, "TestType 512.png");
            this.imageList1.Images.SetKeyName(45, "New Application 64.png");
            this.imageList1.Images.SetKeyName(46, "License Type 32.png");
            this.imageList1.Images.SetKeyName(47, "ApplicationType.png");
            this.imageList1.Images.SetKeyName(48, "Applications.png");
            this.imageList1.Images.SetKeyName(49, "User 32 -2.png");
            this.imageList1.Images.SetKeyName(50, "money 32 - 2.png");
            this.imageList1.Images.SetKeyName(51, "money 32.png");
            this.imageList1.Images.SetKeyName(52, "ApplicationTitle.png");
            this.imageList1.Images.SetKeyName(53, "Application Types 512.png");
            this.imageList1.Images.SetKeyName(54, "Application Types 64.png");
            this.imageList1.Images.SetKeyName(55, "sign_out 32 -2.png");
            this.imageList1.Images.SetKeyName(56, "sign_in 32.png");
            this.imageList1.Images.SetKeyName(57, "Sign Out 32.png");
            this.imageList1.Images.SetKeyName(58, "account_settings 64.png");
            this.imageList1.Images.SetKeyName(59, "SignOut 64.png");
            this.imageList1.Images.SetKeyName(60, "cross 32.png");
            this.imageList1.Images.SetKeyName(61, "cross 64.png");
            this.imageList1.Images.SetKeyName(62, "DVLD Logo.png");
            this.imageList1.Images.SetKeyName(63, "Next 32.png");
            this.imageList1.Images.SetKeyName(64, "Next 64.png");
            this.imageList1.Images.SetKeyName(65, "SearchPerson.png");
            this.imageList1.Images.SetKeyName(66, "Add New User 32.png");
            this.imageList1.Images.SetKeyName(67, "Add New User 72.png");
            this.imageList1.Images.SetKeyName(68, "Users 2 64.png");
            this.imageList1.Images.SetKeyName(69, "Users 2 400.png");
            this.imageList1.Images.SetKeyName(70, "People 400.png");
            this.imageList1.Images.SetKeyName(71, "Password 32.png");
            this.imageList1.Images.SetKeyName(72, "Add Person 40.png");
            this.imageList1.Images.SetKeyName(73, "Add Person 72.png");
            this.imageList1.Images.SetKeyName(74, "Manage People.png");
            this.imageList1.Images.SetKeyName(75, "People 512.png");
            this.imageList1.Images.SetKeyName(76, "AddPerson 32.png");
            this.imageList1.Images.SetKeyName(77, "PersonDetails 32.png");
            this.imageList1.Images.SetKeyName(78, "Female 512.png");
            this.imageList1.Images.SetKeyName(79, "Delete 32.png");
            this.imageList1.Images.SetKeyName(80, "call 32.png");
            this.imageList1.Images.SetKeyName(81, "send email 32.png");
            this.imageList1.Images.SetKeyName(82, "edit 32.png");
            this.imageList1.Images.SetKeyName(83, "Male 512.png");
            this.imageList1.Images.SetKeyName(84, "Number 32.png");
            this.imageList1.Images.SetKeyName(85, "Woman 32.png");
            this.imageList1.Images.SetKeyName(86, "Man 32.png");
            this.imageList1.Images.SetKeyName(87, "Close 32.png");
            this.imageList1.Images.SetKeyName(88, "Save 32.png");
            this.imageList1.Images.SetKeyName(89, "Country 32.png");
            this.imageList1.Images.SetKeyName(90, "Person 32.png");
            this.imageList1.Images.SetKeyName(91, "Calendar 32.png");
            this.imageList1.Images.SetKeyName(92, "Address 32.png");
            this.imageList1.Images.SetKeyName(93, "Email 32.png");
            this.imageList1.Images.SetKeyName(94, "Phone 32.png");
            this.imageList1.Images.SetKeyName(95, "Close 64.png");
            this.imageList1.Images.SetKeyName(96, "Cars 48.png");
            this.imageList1.Images.SetKeyName(97, "List 32.png");
            this.imageList1.Images.SetKeyName(98, "Retake Test 32.png");
            this.imageList1.Images.SetKeyName(99, "Detained Driving License 32.png");
            this.imageList1.Images.SetKeyName(100, "International 32.png");
            this.imageList1.Images.SetKeyName(101, "Local 32.png");
            this.imageList1.Images.SetKeyName(102, "Damaged Driving License 32.png");
            this.imageList1.Images.SetKeyName(103, "Lost Driving License 32.png");
            this.imageList1.Images.SetKeyName(104, "Renew Driving License 32.png");
            this.imageList1.Images.SetKeyName(105, "New Driving License 32.png");
            this.imageList1.Images.SetKeyName(106, "Driver License 32.png");
            this.imageList1.Images.SetKeyName(107, "Drivers 64.png");
            this.imageList1.Images.SetKeyName(108, "users 64.png");
            this.imageList1.Images.SetKeyName(109, "People 64.png");
            this.imageList1.Images.SetKeyName(110, "Applications 64.png");
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmhome";
            this.Text = "frmhome";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pepoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}