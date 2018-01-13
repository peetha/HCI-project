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
using Alice_in_SpringLand.View;

namespace Alice_in_SpringLand
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Start_Load(object sender, EventArgs e)
        {

        }
        //merge pe pagina urmatoare
        private void panelRoom_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void PlaySound(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.start_adventure);
            player.Play();
        }
        private void panelRoom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
