namespace Alice_in_SpringLand.View
{
    partial class Traditions
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
            this.Back = new System.Windows.Forms.Panel();
            this.Sound = new System.Windows.Forms.Panel();
            this.Next_button = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(713, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(66, 72);
            this.Back.TabIndex = 6;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.Transparent;
            this.Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sound.Location = new System.Drawing.Point(713, 184);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(76, 72);
            this.Sound.TabIndex = 7;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            this.Sound.Paint += new System.Windows.Forms.PaintEventHandler(this.Sound_Paint);
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.Color.Transparent;
            this.Next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next_button.Location = new System.Drawing.Point(726, 401);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(63, 62);
            this.Next_button.TabIndex = 8;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            this.Next_button.Paint += new System.Windows.Forms.PaintEventHandler(this.Next_button_Paint);
            // 
            // Traditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alice_in_SpringLand.Properties.Resources.Tradition;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 475);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.Back);
            this.Name = "Traditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.Traditions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.Panel Sound;
        private System.Windows.Forms.Panel Next_button;
    }
}