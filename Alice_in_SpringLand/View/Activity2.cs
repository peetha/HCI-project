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
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Activity1 a = new Activity1();
            //this.Hide();
            a.ShowDialog();
            //this.Show();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Activity3 a = new Activity3();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}
