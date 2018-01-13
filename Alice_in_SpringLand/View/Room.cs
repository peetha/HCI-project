using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alice_in_SpringLand.View;

namespace Alice_in_SpringLand.View
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //panelRoom.MouseEnter += OnMouseEnterButton1;
        }
        private void Room_Load(object sender, EventArgs e)
        {

        }

       

        private void panelPotion_Click(object sender, EventArgs e)
        {
           
            Intersection i = new Intersection();
            this.Hide();
            i.ShowDialog();
            this.Show();
        }

        private void panelRoom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
