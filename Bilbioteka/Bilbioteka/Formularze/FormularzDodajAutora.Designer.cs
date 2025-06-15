namespace BibliotekaNet8.Formularze
{
    partial class FormularzDodajAutora
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtImieNazwisko;
        private System.Windows.Forms.Button btnZapisz;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtImieNazwisko = new TextBox();
            btnZapisz = new Button();
            SuspendLayout();
            // 
            // txtImieNazwisko
            // 
            txtImieNazwisko.Location = new Point(12, 21);
            txtImieNazwisko.Name = "txtImieNazwisko";
            txtImieNazwisko.PlaceholderText = "Imię i nazwisko";
            txtImieNazwisko.Size = new Size(260, 23);
            txtImieNazwisko.TabIndex = 0;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(12, 59);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(260, 30);
            btnZapisz.TabIndex = 1;
            btnZapisz.Text = "Zapisz";
            btnZapisz.Click += btnZapisz_Click;
            // 
            // FormularzDodajAutora
            // 
            ClientSize = new Size(284, 101);
            Controls.Add(txtImieNazwisko);
            Controls.Add(btnZapisz);
            Name = "FormularzDodajAutora";
            Text = "Dodaj autora";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
