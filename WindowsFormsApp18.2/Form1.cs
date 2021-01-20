using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //List<string> lijstZinnen = new List<string>();
        Kat kat;
        Mens mens;
        Papegaai papegaai;
        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnKat.Checked = true;
            lbKiesZin.Items.Add("Hoe gaat het? ");
            lbKiesZin.Items.Add("Hoe heet jij? ");
            lbKiesZin.Items.Add("Goede morgen. ");
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            if (rbtnKat.Checked)
                kat = new Kat(txtNaamDier.Text);
            if (rbtnMens.Checked)
                mens = new Mens(txtNaamDier.Text);
            if (rbtnPapegaai.Checked)
                papegaai = new Papegaai(txtNaamDier.Text);
            txtNaamDier.Clear();
        }

        private void btnPraten_Click(object sender, EventArgs e)
        {
            if (rbtnKat.Checked)
            {
                if (kat == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(kat.Praten(lbKiesZin.SelectedItem.ToString()));
            }
            if (rbtnMens.Checked)
            {
                if (mens == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(mens.Praten(lbKiesZin.SelectedItem.ToString()));
            }
            if (rbtnPapegaai.Checked)
            {
                if (papegaai == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(papegaai.Praten(lbKiesZin.SelectedItem.ToString()));
            }
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DialogResult GeenDierAangemaakt()
        {
            return MessageBox.Show("Er is geen dier aangemaakt. ", "mededeling. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStrelen_Click(object sender, EventArgs e)
        {
            if (rbtnKat.Checked)
            {
                if (kat == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(kat.Strelen());
            }
            if (rbtnMens.Checked)
            {
                if (mens == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(mens.Strelen());
            }
            if (rbtnPapegaai.Checked)
            {
                if (papegaai == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(papegaai.Strelen());
            }
        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            if (rbtnKat.Checked)
            {
                if (kat == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(kat.Eten());
            }
            if (rbtnMens.Checked)
            {
                if (mens == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(mens.Eten());
            }
            if (rbtnPapegaai.Checked)
            {
                if (papegaai == null)
                    GeenDierAangemaakt();
                else
                    MessageBox.Show(papegaai.Eten());
            }
        }
    }
}

