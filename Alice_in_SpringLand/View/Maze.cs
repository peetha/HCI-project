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
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
            
        }
     

        private void Finish_Mouse_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitarii!!");
        }

        private void Start_Mouse_Enter(object sender, EventArgs e)
        {
            Point startPoint = labelStart.Location;
            Cursor.Position = PointToScreen(startPoint);
           
        }

        private void Maze_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = new Cursor("C:\\Windows\\Cursors\\cursor.cur");
        }

        private void panel1_Move(object sender, EventArgs e)
        {
            Cursor.Current = new Cursor("C:\\Windows\\Cursors\\cursor.cur");
        }

        private void labelStart_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = new Cursor("C:\\Windows\\Cursors\\cursor.cur");
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Intersection i = new Intersection();
            this.Hide();
            i.ShowDialog();
            this.Show();
            
        }
    }
}
