using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Collections;

namespace Alice_in_SpringLand.View
{
    public partial class Traditions : Form
    {

        String tipJoc;
        ArrayList animals;
        ArrayList fruits;
        ArrayList vegetables;
        ArrayList weather;
        ArrayList plants;
        Object currentObj;
        int index = -1;

        public Traditions()
        {
            InitializeComponent();
        }

       

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sound_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.start_adventure); //here will be the audio for tradion
            player.Play();
            
        }

        private void Sound_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Traditions_Load(object sender, EventArgs e)
        {

        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            MDay m = new MDay();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void Next_button_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}