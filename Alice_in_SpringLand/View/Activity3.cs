using System;
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
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Activity2 a = new Activity2();
            //this.Hide();
            a.ShowDialog();
            //this.Show();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Activity4 a = new Activity4();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}
