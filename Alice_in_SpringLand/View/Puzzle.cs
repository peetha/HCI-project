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
    public partial class Puzzle : Form
    {

        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        //System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Puzzle()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources.i1, Properties.Resources.i2, Properties.Resources.i3, Properties.Resources.i4, Properties.Resources.i5, Properties.Resources.i6, Properties.Resources.i7, Properties.Resources.i8, Properties.Resources.i9, Properties.Resources.inull });
            lblMovesMade.Text += inmoves;
            //lblTimeElapsed.Text = "00:00:00";
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;//store empty picture box index
                }
            } while (CheckWin());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

            Shuffle();
            //timer.Reset();
            //lblTimeElapsed.Text = "00:00:00";
            inmoves = 0;
            lblMovesMade.Text = "Mutări făcute : 0";
        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {
            
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Mutări făcute : " + (++inmoves);
                    if (CheckWin())
                    {
                        //timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Felicitări!\nAi reușit să rezolvi puxxle-ul. : " + "\nNumăr de mutări : " + inmoves);
                        inmoves = 0;
                        lblMovesMade.Text = "Mutări făcute : 0";
                        Shuffle();
                    }
                }
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Intersection i = new Intersection();
            this.Hide();
            i.ShowDialog();
            this.Show();
            
        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }
    }
}
