using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcija_List
{
    public partial class Form1 : Form
    {
        List<Ucenik> ucenici = new List<Ucenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ucenik ucenik = new Ucenik(txtIme.Text, txtPrezime.Text, txtRazred.Text);
                
                ucenici.Add(ucenik);
                
                txtIme.Clear();
                txtPrezime.Clear();

                MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Ucenik ucenik in ucenici)
            {
                if (ucenik.Razred == "2")
                {
                    ucenik.Razred = "3";
                }

            }
            foreach (Ucenik ucenik in ucenici)
            {
                rtbIspis.AppendText(ucenik.ToString() + "\r\n");
            }
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {

            foreach (Ucenik ucenik in ucenici)
            {
                rtbIspis.AppendText(ucenik.ToString() + "\r\n");
            }
        }
    }
}
