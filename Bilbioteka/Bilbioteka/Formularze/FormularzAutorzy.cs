// FormularzAutorzy.cs
using System;
using System.Linq;
using System.Windows.Forms;
using BibliotekaNet8.Dane;
using BibliotekaNet8.Modele;
using Microsoft.EntityFrameworkCore;

namespace BibliotekaNet8.Formularze
{
    public partial class FormularzAutorzy : Form
    {
        private readonly BibliotekaContext _kontekst;

        public FormularzAutorzy(BibliotekaContext kontekst)
        {
            InitializeComponent();
            _kontekst = kontekst;
            ZaladujAutorow();
        }

        private void ZaladujAutorow()
        {
            dataGridViewAutorzy.DataSource = _kontekst.Autorzy.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string imieNazwisko = txtImieNazwisko.Text.Trim();
            if (string.IsNullOrWhiteSpace(imieNazwisko))
            {
                MessageBox.Show("Podaj imię i nazwisko autora.");
                return;
            }
            var nowyAutor = new Autor { ImieNazwisko = imieNazwisko };
            _kontekst.Autorzy.Add(nowyAutor);
            _kontekst.SaveChanges();
            ZaladujAutorow();
            txtImieNazwisko.Clear();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutorzy.CurrentRow == null)
                return;

            int id = (int)dataGridViewAutorzy.CurrentRow.Cells["Id"].Value;
            var autor = _kontekst.Autorzy.Find(id);
            if (autor != null)
            {
                string noweNazwisko = Microsoft.VisualBasic.Interaction.InputBox("Nowe imię i nazwisko:", "Edytuj autora", autor.ImieNazwisko);
                if (!string.IsNullOrWhiteSpace(noweNazwisko))
                {
                    autor.ImieNazwisko = noweNazwisko;
                    _kontekst.SaveChanges();
                    ZaladujAutorow();
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutorzy.CurrentRow == null)
                return;

            int id = (int)dataGridViewAutorzy.CurrentRow.Cells["Id"].Value;
            var autor = _kontekst.Autorzy
                .Include(a => a.Ksiazki)
                .FirstOrDefault(a => a.Id == id);

            if (autor.Ksiazki.Any())
            {
                MessageBox.Show("Nie można usunąć autora przypisanego do książek.");
                return;
            }

            var confirm = MessageBox.Show("Na pewno usunąć autora?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _kontekst.Autorzy.Remove(autor);
                _kontekst.SaveChanges();
                ZaladujAutorow();
            }
        }
    }
}
