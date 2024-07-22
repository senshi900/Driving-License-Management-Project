namespace Contacts
{
    partial class frmFindWithFillters
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
            this.ctrperson_with_filtter1 = new Contacts.ctrperson_with_filtter();
            this.SuspendLayout();
            // 
            // ctrperson_with_filtter1
            // 
            this.ctrperson_with_filtter1.Location = new System.Drawing.Point(-1, 67);
            this.ctrperson_with_filtter1.Name = "ctrperson_with_filtter1";
            this.ctrperson_with_filtter1.Size = new System.Drawing.Size(870, 392);
            this.ctrperson_with_filtter1.TabIndex = 0;
            // 
            // frmFindWithFillters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.ctrperson_with_filtter1);
            this.Name = "frmFindWithFillters";
            this.Text = "frmFindWithFillters";
            this.Load += new System.EventHandler(this.frmFindWithFillters_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrperson_with_filtter ctrperson_with_filtter1;
    }
}