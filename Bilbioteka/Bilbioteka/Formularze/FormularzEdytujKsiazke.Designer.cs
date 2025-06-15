namespace BibliotekaNet8.Formularze
{
    partial class FormularzEdytujKsiazke
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.CheckBox chkDostepna;
        private System.Windows.Forms.Button btnZapisz;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTytul = new TextBox();
            cmbAutor = new ComboBox();
            dtpData = new DateTimePicker();
            chkDostepna = new CheckBox();
            btnZapisz = new Button();
            SuspendLayout();
            // 
            // txtTytul
            // 
            txtTytul.Location = new Point(12, 12);
            txtTytul.Name = "txtTytul";
            txtTytul.Size = new Size(260, 23);
            txtTytul.TabIndex = 0;
            // 
            // cmbAutor
            // 
            cmbAutor.Location = new Point(12, 41);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(260, 23);
            cmbAutor.TabIndex = 1;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(12, 70);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(260, 23);
            dtpData.TabIndex = 2;
            // 
            // chkDostepna
            // 
            chkDostepna.Location = new Point(168, 108);
            chkDostepna.Name = "chkDostepna";
            chkDostepna.Size = new Size(104, 24);
            chkDostepna.TabIndex = 3;
            chkDostepna.Text = "Dostępna";
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(12, 138);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(260, 30);
            btnZapisz.TabIndex = 4;
            btnZapisz.Text = "Zapisz zmiany";
            btnZapisz.Click += btnZapisz_Click;
            // 
            // FormularzEdytujKsiazke
            // 
            ClientSize = new Size(284, 180);
            Controls.Add(txtTytul);
            Controls.Add(cmbAutor);
            Controls.Add(dtpData);
            Controls.Add(chkDostepna);
            Controls.Add(btnZapisz);
            Name = "FormularzEdytujKsiazke";
            Text = "Edytuj książkę";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
