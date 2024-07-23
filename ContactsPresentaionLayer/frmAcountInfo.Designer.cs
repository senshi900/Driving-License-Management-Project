namespace Contacts
{
    partial class frmAcountInfo
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
            this.lbusername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.lbisactive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlUser1
            // 
            this.ctrlUser1.Location = new System.Drawing.Point(12, 26);
            this.ctrlUser1.Name = "ctrlUser1";
            this.ctrlUser1.Size = new System.Drawing.Size(845, 277);
            this.ctrlUser1.TabIndex = 0;
            this.ctrlUser1.Load += new System.EventHandler(this.ctrlUser1_Load);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(499, 356);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(33, 16);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "user ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "IsActive :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(223, 356);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(20, 16);
            this.lbid.TabIndex = 5;
            this.lbid.Text = "ID";
            // 
            // lbisactive
            // 
            this.lbisactive.AutoSize = true;
            this.lbisactive.Location = new System.Drawing.Point(859, 356);
            this.lbisactive.Name = "lbisactive";
            this.lbisactive.Size = new System.Drawing.Size(43, 16);
            this.lbisactive.TabIndex = 6;
            this.lbisactive.Text = "active";
            // 
            // frmAcountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.lbisactive);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.ctrlUser1);
            this.Name = "frmAcountInfo";
            this.Text = "frmAcountInfo";
            this.Load += new System.EventHandler(this.frmAcountInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUser ctrlUser1;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbisactive;
    }
}