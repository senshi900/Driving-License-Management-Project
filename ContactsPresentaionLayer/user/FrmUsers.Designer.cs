﻿namespace Contacts.user
{
    partial class FrmUsers
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
            this.control_pepole1 = new Contacts.control_pepole();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // control_pepole1
            // 
            this.control_pepole1.Location = new System.Drawing.Point(33, 68);
            this.control_pepole1.Name = "control_pepole1";
            this.control_pepole1.Size = new System.Drawing.Size(882, 388);
            this.control_pepole1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(835, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 59);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 468);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.control_pepole1);
            this.Name = "FrmUsers";
            this.Text = "FrmUsers";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private control_pepole control_pepole1;
        private System.Windows.Forms.Button btnAdd;
    }
}