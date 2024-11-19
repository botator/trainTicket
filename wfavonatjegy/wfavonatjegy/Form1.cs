using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfavonatjegy
{
    public partial class Form1 : Form
    {
        int km = 0;
        int tipus = 0;
        bool kieg = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btszamol_Click(object sender, EventArgs e)
        {
            szamolas();
        }


        private void szamolas()
        {
            double fizetendo = 0;
            if (txkm.TextLength > 0)
            {
                fizetendo = Convert.ToDouble(txkm.Text) * 25;
                if (rb50.Checked)
                {
                    fizetendo = fizetendo * 0.5;
                }
                if (rb90.Checked)
                {
                    fizetendo = fizetendo * 0.1;
                }
                if (rbigen.Checked) { fizetendo += 150; }
            }
            label5.Visible = true;
            label5.Text = "fizetendő: "+fizetendo.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbteljes_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rb50_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rb90_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rbnem_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rbigen_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }
    }
}
