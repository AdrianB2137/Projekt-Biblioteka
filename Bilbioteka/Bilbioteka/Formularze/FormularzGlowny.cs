using BibliotekaNet8.Dane;
using BibliotekaNet8.Modele;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BibliotekaNet8.Formularze
{
    public partial class FormularzGlowny : Form
    {
        private readonly BibliotekaContext _kontekst;

        public FormularzGlowny(BibliotekaContext kontekst)
        {
            _kontekst = kontekst;
            InitializeComponent();
        }

        private void FormularzGlowny_Load(object sender, EventArgs e)
        {
            OdswiezTabele();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var formularz = new FormularzDodajKsiazke(_kontekst);
            formularz.ShowDialog();
            OdswiezTabele();
        }

        private void OdswiezTabele()
        {
            dataGridView1.DataSource = _kontekst.Ksiazki
                .Select(k => new
                {
                    k.Id,
                    k.Tytul,
                    Autor = k.Autor.ImieNazwisko,
                    k.DataWydania,
                    k.Dostepna
                })
                .ToList();

            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            string tytul = dataGridView1.CurrentRow.Cells["Tytul"].Value.ToString();
            var ksiazka = _kontekst.Ksiazki.FirstOrDefault(k => k.Tytul == tytul);

            _kontekst.Ksiazki.Remove(ksiazka);
            _kontekst.SaveChanges();
            MessageBox.Show("Ksi¹¿ka zosta³a usuniêta.");
            OdswiezTabele();
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            var formularz = new FormularzDodajAutora(_kontekst);
            formularz.ShowDialog();
            OdswiezTabele();
        }

        private void btnZmienDostepnosc_Click(object sender, EventArgs e)
        {
            string tytul = dataGridView1.CurrentRow.Cells["Tytul"].Value.ToString();
            var ksiazka = _kontekst.Ksiazki.FirstOrDefault(k => k.Tytul == tytul);

            ksiazka.Dostepna = !ksiazka.Dostepna;
            _kontekst.SaveChanges();

            MessageBox.Show($"Dostêpnoœæ ksi¹¿ki zosta³a zmieniona na: {(ksiazka.Dostepna ? "Dostêpna" : "Niedostêpna")}");
            OdswiezTabele();
        }

        private void btnEdytujKsiazke_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Zaznacz ksi¹¿kê do edycji.");
                return;
            }

            int idKsiazki = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            var ksiazka = _kontekst.Ksiazki.FirstOrDefault(k => k.Id == idKsiazki);

            if (ksiazka != null)
            {
                var formularz = new FormularzEdytujKsiazke(_kontekst, ksiazka);
                formularz.ShowDialog();
                OdswiezTabele();
            }
        }

        private void btnAutorzy_Click(object sender, EventArgs e)
        {
            var formularz = new FormularzAutorzy(_kontekst);
            formularz.ShowDialog();
            OdswiezTabele();
        }
    }
}
