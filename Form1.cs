using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_w3
{
    public partial class main : Form
    {
        public bool second = false;
        second form2 = new second();
        public main()
        {
            InitializeComponent();
        }

        private void cek_MouseClick(object sender, MouseEventArgs e)
        {
            if (cek.Checked)
            {
                submit.Enabled = true;
            }
            if (cek.Checked == false)
            {
                submit.Enabled = false;
            }
        }

        private void open_MouseClick(object sender, MouseEventArgs e)
        {
            form2.Show(this);
            second = true;
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_SecondClicked(object sender, EventArgs e)
        {
            
        }

        private void submit_MouseClick(object sender, MouseEventArgs e)
        {
            if (second == true && inputnama.Text != "" && inputartis.Text != "")
            {
                form2.gantilabel(inputnama.Text, inputartis.Text);
            }
            else
            {
                MessageBox.Show("Please enter the correct input");
            }
        }
        
    }
}
