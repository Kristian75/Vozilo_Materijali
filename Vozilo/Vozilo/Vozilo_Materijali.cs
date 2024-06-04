using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozilo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            // Provjerava jesu li uneseni podaci
            if (txtMarka.Text != "" && txtModel.Text != "")
            {
                // Dodaj vozilo u listu
                vozila.Add(new Vozilo(txtMarka.Text, txtModel.Text, cmbVrsta.Text));
                MessageBox.Show("Vozilo je uspješno dodano!");
                // Prazni tekstualna polja nakon unosa
                txtMarka.Clear();
                txtModel.Clear();
                cmbVrsta.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Molimo unesite sve potrebne podatke.");
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            // Obrađuje svako vozilo prema vrsti
            foreach (Vozilo v in vozila)
            {
                if (v.Vrsta == "Avion")
                    v.VoziPo = "Zrak";
                else if (v.Vrsta == "Automobil")
                    v.VoziPo = "Cesta";
                else if (v.Vrsta == "Brod")
                    v.VoziPo = "Voda";
            }
            MessageBox.Show("Podaci su uspješno obrađeni!");
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            // Ispisuje podatke o vozilima
            string ispis = "Podaci o vozilima:\n\n";
            foreach (Vozilo v in vozila)
            {
                ispis += $"Marka: {v.Marka}, Model: {v.Model}, Vrsta: {v.Vrsta}, Vozi po: {v.VoziPo}\n";
            }
            MessageBox.Show(ispis);
        }
    }
}
