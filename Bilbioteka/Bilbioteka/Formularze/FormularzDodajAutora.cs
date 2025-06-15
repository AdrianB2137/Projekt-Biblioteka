using BibliotekaNet8.Dane;
using BibliotekaNet8.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaNet8.Formularze
{
    public partial class FormularzDodajAutora : Form
    {
        private readonly BibliotekaContext _kontekst;

        public FormularzDodajAutora(BibliotekaContext kontekst)
        {
            _kontekst = kontekst;
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string imieNazwisko = txtImieNazwisko.Text.Trim();

            if (string.IsNullOrEmpty(imieNazwisko))
            {
                MessageBox.Show("Podaj imię i nazwisko autora.");
                return;
            }

            var autor = new Autor
            {
                ImieNazwisko = imieNazwisko
            };

            _kontekst.Autorzy.Add(autor);
            _kontekst.SaveChanges();

            MessageBox.Show("Autor został dodany.");
            this.Close();
        }
    }
}