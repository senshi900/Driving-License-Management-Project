namespace Contacts.license
{
    partial class frmNewLocalLicense
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbinfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrperson_with_filtter1 = new Contacts.ctrperson_with_filtter();
            this.tbApplication = new System.Windows.Forms.TabPage();
            this.btnsSave = new System.Windows.Forms.Button();
            this.lbfees = new System.Windows.Forms.Label();
            this.lbcreatedby = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbinfo.SuspendLayout();
            this.tbApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbinfo);
            this.tabControl1.Controls.Add(this.tbApplication);
            this.tabControl1.Location = new System.Drawing.Point(86, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tbinfo
            // 
            this.tbinfo.Controls.Add(this.btnNext);
            this.tbinfo.Controls.Add(this.ctrperson_with_filtter1);
            this.tbinfo.Location = new System.Drawing.Point(4, 25);
            this.tbinfo.Name = "tbinfo";
            this.tbinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbinfo.Size = new System.Drawing.Size(994, 489);
            this.tbinfo.TabIndex = 0;
            this.tbinfo.Text = "Personal Info";
            this.tbinfo.UseVisualStyleBackColor = true;
            this.tbinfo.Click += new System.EventHandler(this.tbinfo_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(837, 418);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 46);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrperson_with_filtter1
            // 
            this.ctrperson_with_filtter1.Location = new System.Drawing.Point(50, 51);
            this.ctrperson_with_filtter1.Name = "ctrperson_with_filtter1";
            this.ctrperson_with_filtter1.Size = new System.Drawing.Size(870, 392);
            this.ctrperson_with_filtter1.TabIndex = 0;
            // 
            // tbApplication
            // 
            this.tbApplication.Controls.Add(this.btnsSave);
            this.tbApplication.Controls.Add(this.lbfees);
            this.tbApplication.Controls.Add(this.lbcreatedby);
            this.tbApplication.Controls.Add(this.comboBox1);
            this.tbApplication.Controls.Add(this.lbDate);
            this.tbApplication.Controls.Add(this.lbID);
            this.tbApplication.Controls.Add(this.label5);
            this.tbApplication.Controls.Add(this.label4);
            this.tbApplication.Controls.Add(this.label3);
            this.tbApplication.Controls.Add(this.label2);
            this.tbApplication.Controls.Add(this.label1);
            this.tbApplication.Location = new System.Drawing.Point(4, 25);
            this.tbApplication.Name = "tbApplication";
            this.tbApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tbApplication.Size = new System.Drawing.Size(994, 489);
            this.tbApplication.TabIndex = 1;
            this.tbApplication.Text = "Application Info";
            this.tbApplication.UseVisualStyleBackColor = true;
            this.tbApplication.Click += new System.EventHandler(this.tbApplication_Click);
            // 
            // btnsSave
            // 
            this.btnsSave.Location = new System.Drawing.Point(875, 413);
            this.btnsSave.Name = "btnsSave";
            this.btnsSave.Size = new System.Drawing.Size(98, 51);
            this.btnsSave.TabIndex = 12;
            this.btnsSave.Text = "Save";
            this.btnsSave.UseVisualStyleBackColor = true;
            this.btnsSave.Click += new System.EventHandler(this.btnsSave_Click);
            // 
            // lbfees
            // 
            this.lbfees.AutoSize = true;
            this.lbfees.Location = new System.Drawing.Point(230, 244);
            this.lbfees.Name = "lbfees";
            this.lbfees.Size = new System.Drawing.Size(28, 16);
            this.lbfees.TabIndex = 10;
            this.lbfees.Text = "???";
            // 
            // lbcreatedby
            // 
            this.lbcreatedby.AutoSize = true;
            this.lbcreatedby.Location = new System.Drawing.Point(203, 293);
            this.lbcreatedby.Name = "lbcreatedby";
            this.lbcreatedby.Size = new System.Drawing.Size(35, 16);
            this.lbcreatedby.TabIndex = 9;
            this.lbcreatedby.Text = "????";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(230, 141);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 16);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "label8";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(214, 95);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(28, 16);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Application Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Classs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application ID: ";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(990, 591);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(109, 46);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(855, 591);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmNewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmNewLocalLicense";
            this.Text = "frmNewLocalLicense";
            this.Load += new System.EventHandler(this.frmNewLocalLicense_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbinfo.ResumeLayout(false);
            this.tbApplication.ResumeLayout(false);
            this.tbApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbinfo;
        private ctrperson_with_filtter ctrperson_with_filtter1;
        private System.Windows.Forms.TabPage tbApplication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbfees;
        private System.Windows.Forms.Label lbcreatedby;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnsSave;
    }
}