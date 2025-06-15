namespace BibliotekaNet8.Formularze
{
    partial class FormularzAutorzy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtImieNazwisko;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.DataGridView dataGridViewAutorzy;
        private System.Windows.Forms.Label lblImieNazwisko;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtImieNazwisko = new TextBox();
            btnDodaj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            dataGridViewAutorzy = new DataGridView();
            lblImieNazwisko = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutorzy).BeginInit();
            SuspendLayout();
            // 
            // txtImieNazwisko
            // 
            txtImieNazwisko.Location = new Point(12, 25);
            txtImieNazwisko.Name = "txtImieNazwisko";
            txtImieNazwisko.Size = new Size(250, 23);
            txtImieNazwisko.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(280, 25);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(90, 33);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Location = new Point(376, 25);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(90, 33);
            btnEdytuj.TabIndex = 3;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(472, 25);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(90, 33);
            btnUsun.TabIndex = 4;
            btnUsun.Text = "Usuń";
            btnUsun.Click += btnUsun_Click;
            // 
            // dataGridViewAutorzy
            // 
            dataGridViewAutorzy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAutorzy.Location = new Point(12, 64);
            dataGridViewAutorzy.Name = "dataGridViewAutorzy";
            dataGridViewAutorzy.ReadOnly = true;
            dataGridViewAutorzy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAutorzy.Size = new Size(550, 296);
            dataGridViewAutorzy.TabIndex = 5;
            // 
            // lblImieNazwisko
            // 
            lblImieNazwisko.Location = new Point(12, 5);
            lblImieNazwisko.Name = "lblImieNazwisko";
            lblImieNazwisko.Size = new Size(100, 23);
            lblImieNazwisko.TabIndex = 1;
            lblImieNazwisko.Text = "Imię i nazwisko autora:";
            // 
            // FormularzAutorzy
            // 
            ClientSize = new Size(574, 380);
            Controls.Add(txtImieNazwisko);
            Controls.Add(lblImieNazwisko);
            Controls.Add(btnDodaj);
            Controls.Add(btnEdytuj);
            Controls.Add(btnUsun);
            Controls.Add(dataGridViewAutorzy);
            Name = "FormularzAutorzy";
            Text = "Zarządzanie autorami";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutorzy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
