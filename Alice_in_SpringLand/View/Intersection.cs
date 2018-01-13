using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alice_in_SpringLand.View
{
    public partial class Intersection : Form
    {
        public Intersection()
        {
            InitializeComponent();
        }

        private void panelFlowers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFruits_Click(object sender, EventArgs e)
        {
            Apple a = new Apple();
            this.Hide();
            a.ShowDialog();
            this.Show();

        }

        private void panelFlowers_Click(object sender, EventArgs e)
        {
           Snowdrop s = new Snowdrop();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void panelTraditions_Click(object sender, EventArgs e)
        {
            Traditions a = new Traditions();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void panelActivities_Click(object sender, EventArgs e)
        {
            Activity1 a = new Activity1();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void panelFruits_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
