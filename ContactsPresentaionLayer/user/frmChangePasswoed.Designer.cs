namespace Contacts.user
{
    partial class frmChangePass
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
            this.ctrlUser1 = new Contacts.ctrlUser();
            this.lbisactive = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbconfirmpass = new System.Windows.Forms.TextBox();
            this.tbnewpass = new System.Windows.Forms.TextBox();
            this.tbcurrentpasswoed = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlUser1
            // 
            this.ctrlUser1.Location = new System.Drawing.Point(0, 45);
            this.ctrlUser1.Name = "ctrlUser1";
            this.ctrlUser1.Size = new System.Drawing.Size(845, 277);
            this.ctrlUser1.TabIndex = 0;
            // 
            // lbisactive
            // 
            this.lbisactive.AutoSize = true;
            this.lbisactive.Location = new System.Drawing.Point(803, 355);
            this.lbisactive.Name = "lbisactive";
            this.lbisactive.Size = new System.Drawing.Size(43, 16);
            this.lbisactive.TabIndex = 12;
            this.lbisactive.Text = "active";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(167, 355);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(20, 16);
            this.lbid.TabIndex = 11;
            this.lbid.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "IsActive :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "user ID : ";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(443, 355);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(33, 16);
            this.lbusername.TabIndex = 7;
            this.lbusername.Text = "user";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "confirm Password";
            // 
            // tbconfirmpass
            // 
            this.tbconfirmpass.Location = new System.Drawing.Point(218, 575);
            this.tbconfirmpass.Name = "tbconfirmpass";
            this.tbconfirmpass.Size = new System.Drawing.Size(100, 22);
            this.tbconfirmpass.TabIndex = 16;
            // 
            // tbnewpass
            // 
            this.tbnewpass.Location = new System.Drawing.Point(218, 519);
            this.tbnewpass.Name = "tbnewpass";
            this.tbnewpass.Size = new System.Drawing.Size(100, 22);
            this.tbnewpass.TabIndex = 17;
            // 
            // tbcurrentpasswoed
            // 
            this.tbcurrentpasswoed.Location = new System.Drawing.Point(218, 471);
            this.tbcurrentpasswoed.Name = "tbcurrentpasswoed";
            this.tbcurrentpasswoed.Size = new System.Drawing.Size(100, 22);
            this.tbcurrentpasswoed.TabIndex = 18;
            this.tbcurrentpasswoed.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(819, 561);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(113, 72);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(664, 561);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(120, 69);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 662);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tbcurrentpasswoed);
            this.Controls.Add(this.tbnewpass);
            this.Controls.Add(this.tbconfirmpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbisactive);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.ctrlUser1);
            this.Name = "frmChangePass";
            this.Text = "frmChangePasswoed";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUser ctrlUser1;
        private System.Windows.Forms.Label lbisactive;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbconfirmpass;
        private System.Windows.Forms.TextBox tbnewpass;
        private System.Windows.Forms.TextBox tbcurrentpasswoed;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
    }
}