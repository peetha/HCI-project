﻿namespace Alice_in_SpringLand.View
{
    partial class Cherry
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
            this.Back_button = new System.Windows.Forms.Panel();
            this.Next_button = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.Transparent;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_button.Location = new System.Drawing.Point(12, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(52, 59);
            this.Back_button.TabIndex = 9;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            this.Back_button.Paint += new System.Windows.Forms.PaintEventHandler(this.Back_button_Paint);
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.Color.Transparent;
            this.Next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next_button.Location = new System.Drawing.Point(711, 395);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(68, 68);
            this.Next_button.TabIndex = 10;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Cherry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alice_in_SpringLand.Properties.Resources.Cherry;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 475);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Back_button);
            this.Name = "Cherry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cherry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Back_button;
        private System.Windows.Forms.Panel Next_button;
    }
}