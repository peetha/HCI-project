﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alice_in_SpringLand.View
{
    public partial class Cherry : Form
    {
        public Cherry()
        {
            InitializeComponent();
        }

        private void Back_button_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Peach p = new Peach();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
