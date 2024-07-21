namespace Contacts
{
    partial class frm_person_info
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
            this.user2 = new Contacts.ctrlUser();
            this.SuspendLayout();
            // 
            // user2
            // 
            this.user2.Location = new System.Drawing.Point(50, 12);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(971, 499);
            this.user2.TabIndex = 0;
            this.user2.Load += new System.EventHandler(this.user2_Load);
            // 
            // frm_person_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 523);
            this.Controls.Add(this.user2);
            this.Name = "frm_person_info";
            this.Text = "frm_person_info";
            this.Load += new System.EventHandler(this.frm_person_info_Load);
            this.ResumeLayout(false);

        }

        #endregion

  
        private ctrlUser user2;
    }
}