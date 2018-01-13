namespace Alice_in_SpringLand.View
{
    partial class Intersection
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
            this.panelFlowers = new System.Windows.Forms.Panel();
            this.panelFruits = new System.Windows.Forms.Panel();
            this.panelTraditions = new System.Windows.Forms.Panel();
            this.panelActivities = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFlowers
            // 
            this.panelFlowers.BackColor = System.Drawing.Color.Transparent;
            this.panelFlowers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFlowers.Location = new System.Drawing.Point(428, 218);
            this.panelFlowers.Name = "panelFlowers";
            this.panelFlowers.Size = new System.Drawing.Size(108, 32);
            this.panelFlowers.TabIndex = 6;
            this.panelFlowers.Click += new System.EventHandler(this.panelFlowers_Click);
            this.panelFlowers.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFlowers_Paint);
            // 
            // panelFruits
            // 
            this.panelFruits.BackColor = System.Drawing.Color.Transparent;
            this.panelFruits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFruits.Location = new System.Drawing.Point(414, 170);
            this.panelFruits.Name = "panelFruits";
            this.panelFruits.Size = new System.Drawing.Size(108, 32);
            this.panelFruits.TabIndex = 7;
            this.panelFruits.Click += new System.EventHandler(this.panelFruits_Click);
            this.panelFruits.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFruits_Paint);
            // 
            // panelTraditions
            // 
            this.panelTraditions.BackColor = System.Drawing.Color.Transparent;
            this.panelTraditions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTraditions.Location = new System.Drawing.Point(414, 273);
            this.panelTraditions.Name = "panelTraditions";
            this.panelTraditions.Size = new System.Drawing.Size(122, 41);
            this.panelTraditions.TabIndex = 8;
            this.panelTraditions.Click += new System.EventHandler(this.panelTraditions_Click);
            // 
            // panelActivities
            // 
            this.panelActivities.BackColor = System.Drawing.Color.Transparent;
            this.panelActivities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelActivities.Location = new System.Drawing.Point(414, 351);
            this.panelActivities.Name = "panelActivities";
            this.panelActivities.Size = new System.Drawing.Size(122, 42);
            this.panelActivities.TabIndex = 9;
            this.panelActivities.Click += new System.EventHandler(this.panelActivities_Click);
            // 
            // Intersection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alice_in_SpringLand.Properties.Resources.indicators;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 475);
            this.Controls.Add(this.panelActivities);
            this.Controls.Add(this.panelTraditions);
            this.Controls.Add(this.panelFruits);
            this.Controls.Add(this.panelFlowers);
            this.Name = "Intersection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intersection";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFlowers;
        private System.Windows.Forms.Panel panelFruits;
        private System.Windows.Forms.Panel panelTraditions;
        private System.Windows.Forms.Panel panelActivities;
    }
}