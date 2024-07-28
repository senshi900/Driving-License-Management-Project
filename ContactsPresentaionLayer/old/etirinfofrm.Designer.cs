namespace Contacts
{
    partial class etirinfofrm
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
            this.lbid1 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();

            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbid1
            // 
            this.lbid1.AutoSize = true;
            this.lbid1.Location = new System.Drawing.Point(30, 104);
            this.lbid1.Name = "lbid1";
            this.lbid1.Size = new System.Drawing.Size(21, 16);
            this.lbid1.TabIndex = 0;
            this.lbid1.Text = "id:";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(30, 195);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(47, 16);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(178, 43);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(18, 16);
            this.lbid.TabIndex = 2;
            this.lbid.Text = "id";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(30, 263);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(52, 16);
            this.lbphone.TabIndex = 3;
            this.lbphone.Text = "Phone :";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(96, 195);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 22);
            this.tbname.TabIndex = 4;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(96, 263);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(100, 22);
            this.tbphone.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(347, 410);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(134, 46);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // simplecalc2
            // 

            // 
            // simplecalc1
            // 

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etirinfofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 504);
            this.Controls.Add(this.button1);

            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbphone);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbid1);
            this.Name = "etirinfofrm";
            this.Text = "etirinfofrm";
            this.Load += new System.EventHandler(this.etirinfofrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbid1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Button btnsave;

        private System.Windows.Forms.Button button1;
    }
}