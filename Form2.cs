using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_w3
{
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }

        private void magic_Click(object sender, EventArgs e)
        {
            main form1 = (main)this.Owner;
            bool backcolor = true;
            bool textcolor = true;
            if (merah.Checked == false && biru.Checked == false && hijau.Checked == false && ungu.Checked == false && hitam.Checked == false)
            {
                backcolor = false;
            }
            if (tulismerah.Checked == false && tulisbiru.Checked == false && tulishijau.Checked == false)
            {
                textcolor = false;  
            }

            if (backcolor == false || textcolor == false)
            {
                MessageBox.Show("Please choose color from the radio button");
            }
            if (backcolor == true && textcolor == true)
            {
                if (merah.Checked)
                {
                    form1.BackColor = Color.Red;
                }
                else if (biru.Checked)
                {
                    form1.BackColor = Color.Blue;
                }
                else if (hijau.Checked)
                {
                    form1.BackColor = Color.Green;
                }
                else if (ungu.Checked)
                {
                    form1.BackColor = Color.Purple;
                }
                else if (hitam.Checked)
                {
                    form1.BackColor = Color.Black;
                }

                if (tulismerah.Checked)
                {
                    form1.ForeColor = Color.Red;
                }
                else if (tulisbiru.Checked)
                {
                    form1.ForeColor = Color.Blue;
                }
                else if (tulishijau.Checked)
                {
                    form1.ForeColor = Color.Green;
                }
            }            
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void cek1_CheckedChanged(object sender, EventArgs e)
        {
            if (cek1.Checked && cek2.Checked)
            {
                magic.Enabled = true;
            }
            if (cek1.Checked == false || cek2.Checked == false)
            {
                magic.Enabled = false;
            }
        }

        private void cek2_CheckedChanged(object sender, EventArgs e)
        {
            if (cek1.Checked && cek2.Checked)
            {
                magic.Enabled = true;
            }
            if (cek1.Checked == false || cek2.Checked == false)
            {
                magic.Enabled = false;
            }
        }

        public void gantilabel(string NAMA, string NAMAARTIS)
        {
            hasil.Text = ("Hi, my name is " + NAMA + " and my favorite artist is " + NAMAARTIS);
        }
    }
}
