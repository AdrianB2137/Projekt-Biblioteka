using System;
using System.Linq;
using System.Windows.Forms;
using BibliotekaNet8.Dane;
using BibliotekaNet8.Modele;

namespace BibliotekaNet8.Formularze
{
    public partial class FormularzDodajKsiazke : Form
    {
        private readonly BibliotekaContext _kontekst;

        public FormularzDodajKsiazke(BibliotekaContext kontekst)
        {
            _kontekst = kontekst;
            InitializeComponent();
            ZaladujAutorow();
        }

        private void ZaladujAutorow()
        {
            var autorzy = _kontekst.Autorzy.ToList();
            cmbAutor.DataSource = autorzy;
            cmbAutor.DisplayMember = "ImieNazwisko";
            cmbAutor.ValueMember = "Id";
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTytul.Text))
            {
                MessageBox.Show("Tytuł książki nie może być pusty.");
                return;
            }

            try
            {
                var ksiazka = new Ksiazka
                {
                    Tytul = txtTytul.Text,
                    AutorId = (int)cmbAutor.SelectedValue,
                    DataWydania = dtpData.Value.Date,
                    Dostepna = chkDostepna.Checked
                };

                _kontekst.Ksiazki.Add(ksiazka);
                _kontekst.SaveChanges();

                MessageBox.Show("Książka została dodana.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisu:\n" + ex.InnerException?.Message ?? ex.Message);
            }
        }

    }
}
