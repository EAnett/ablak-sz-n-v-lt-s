using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ablak_szín_váltás
{
    public partial class Ablak : Form
    {
        public Ablak()
        {
            InitializeComponent();
        }

        private void btn_megad_Click(object sender, EventArgs e)
        {

            if (cb_box_hatter.SelectedIndex == 0)
            {
                tbx_szoveg.BackColor=Color.IndianRed;
            }
            if (cb_box_hatter.SelectedIndex == 1)
            {
                tbx_szoveg.BackColor = Color.LightYellow;
            }
            if (cb_box_hatter.SelectedIndex == 2)
            {
                tbx_szoveg.BackColor = Color.MidnightBlue;
            }
            if (cb_box_hatter.SelectedIndex == 3)
            {
                tbx_szoveg.BackColor = Color.Lime;
            }
            if (cb_box_hatter.SelectedIndex == 4)
            {
                tbx_szoveg.BackColor = Color.WhiteSmoke;
            }
            if (cb_box_hatter.SelectedIndex == 5)
            {
                tbx_szoveg.BackColor = Color.Black;
            }
            if (cb_box_hatter.SelectedIndex == 6)
            {
                tbx_szoveg.BackColor = Color.MediumPurple;
            }
            if (cb_box_hatter.SelectedIndex == 7)
            {
                tbx_szoveg.BackColor = Color.SandyBrown;
            }
            if (cb_box_hatter.SelectedIndex == 8)
            {
                tbx_szoveg.BackColor = Color.LightSlateGray;
            }

            if (cb_box_szoveg.SelectedIndex == 0)
            {
                tbx_szoveg.ForeColor = Color.Red;
            }
            if (cb_box_szoveg.SelectedIndex == 1)
            {
                tbx_szoveg.ForeColor = Color.LightBlue;
            }
            if (cb_box_szoveg.SelectedIndex == 2)
            {
                tbx_szoveg.ForeColor = Color.DarkSeaGreen;
            }
            if (cb_box_szoveg.SelectedIndex == 3)
            {
                tbx_szoveg.ForeColor = Color.LightGoldenrodYellow;
            }
            if (cb_box_szoveg.SelectedIndex == 4)
            {
                tbx_szoveg.ForeColor = Color.NavajoWhite;
            }
            if (cb_box_szoveg.SelectedIndex == 5)
            {
                tbx_szoveg.ForeColor = Color.Black;
            }
            if (cb_box_szoveg.SelectedIndex == 6)
            {
                tbx_szoveg.ForeColor = Color.MediumPurple;
            }
            if (cb_box_szoveg.SelectedIndex == 7)
            {
                tbx_szoveg.ForeColor = Color.DarkGray;
            }
            if (cb_box_szoveg.SelectedIndex == 8)
            {
                tbx_szoveg.ForeColor = Color.RosyBrown;
            }
        }

        private void btn_kerdes_Click(object sender, EventArgs e)
        {
            tbx_szoveg.Clear();
            
        }
    }
}
