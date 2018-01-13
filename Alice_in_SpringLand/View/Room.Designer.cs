using System;
using System.Windows.Forms;

namespace Alice_in_SpringLand.View
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel panelRoom;

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
            this.panelRoom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelRoom
            // 
            this.panelRoom.BackColor = System.Drawing.Color.Transparent;
            this.panelRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRoom.Location = new System.Drawing.Point(576, 77);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(43, 76);
            this.panelRoom.TabIndex = 5;
            this.panelRoom.Click += new System.EventHandler(this.panelPotion_Click);
            this.panelRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRoom_Paint);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::Alice_in_SpringLand.Properties.Resources.room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 475);
            this.Controls.Add(this.panelRoom);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }


        #endregion
    }
}