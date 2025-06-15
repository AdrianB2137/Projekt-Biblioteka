using System;
using System.Linq;
using System.Windows.Forms;
using BibliotekaNet8.Dane;
using BibliotekaNet8.Modele;

namespace BibliotekaNet8.Formularze
{
    public partial class FormularzEdytujKsiazke : Form
    {
        private readonly BibliotekaContext _kontekst;
        private readonly Ksiazka _ksiazka;

        public FormularzEdytujKsiazke(BibliotekaContext kontekst, Ksiazka ksiazka)
        {
            InitializeComponent();
            _kontekst = kontekst;
            _ksiazka = ksiazka;

            cmbAutor.DataSource = _kontekst.Autorzy.ToList();
            cmbAutor.DisplayMember = "ImieNazwisko";
            cmbAutor.ValueMember = "Id";

            txtTytul.Text = ksiazka.Tytul;
            cmbAutor.SelectedValue = ksiazka.AutorId;
            dtpData.Value = ksiazka.DataWydania;
            chkDostepna.Checked = ksiazka.Dostepna;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTytul.Text))
            {
                MessageBox.Show("Tytuł nie może być pusty.");
                return;
            }

            _ksiazka.Tytul = txtTytul.Text.Trim();
            _ksiazka.AutorId = (int)cmbAutor.SelectedValue;
            _ksiazka.DataWydania = dtpData.Value.Date;
            _ksiazka.Dostepna = chkDostepna.Checked;

            _kontekst.SaveChanges();
            MessageBox.Show("Zapisano zmiany.");
            this.Close();
        }
    }
}