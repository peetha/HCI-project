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
    public partial class Radish : Form
    {
        public Radish()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Salad s = new Salad();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }
    }
}
