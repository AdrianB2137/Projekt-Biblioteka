namespace BibliotekaNet8.Formularze
{
    partial class FormularzGlowny
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodajAutora;
        private System.Windows.Forms.Button btnZmienDostepnosc;
        private System.Windows.Forms.Button btnEdytujKsiazke;
        private System.Windows.Forms.Button btnAutorzy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnDodaj = new Button();
            btnUsun = new Button();
            btnDodajAutora = new Button();
            btnZmienDostepnosc = new Button();
            btnEdytujKsiazke = new Button();
            btnAutorzy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(836, 250);
            dataGridView1.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(200, 313);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(491, 46);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj książkę";
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Dock = DockStyle.Right;
            btnUsun.Location = new Point(688, 250);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(148, 109);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "Usuń książkę";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnDodajAutora
            // 
            btnDodajAutora.Location = new Point(0, 250);
            btnDodajAutora.Name = "btnDodajAutora";
            btnDodajAutora.Size = new Size(203, 63);
            btnDodajAutora.TabIndex = 3;
            btnDodajAutora.Text = "Dodaj autora";
            btnDodajAutora.UseVisualStyleBackColor = true;
            btnDodajAutora.Click += btnDodajAutora_Click;
            // 
            // btnZmienDostepnosc
            // 
            btnZmienDostepnosc.Location = new Point(463, 250);
            btnZmienDostepnosc.Name = "btnZmienDostepnosc";
            btnZmienDostepnosc.Size = new Size(228, 63);
            btnZmienDostepnosc.TabIndex = 4;
            btnZmienDostepnosc.Text = "Zmień dostępność";
            btnZmienDostepnosc.UseVisualStyleBackColor = true;
            btnZmienDostepnosc.Click += btnZmienDostepnosc_Click;
            // 
            // btnEdytujKsiazke
            // 
            btnEdytujKsiazke.Location = new Point(200, 250);
            btnEdytujKsiazke.Name = "btnEdytujKsiazke";
            btnEdytujKsiazke.Size = new Size(267, 63);
            btnEdytujKsiazke.TabIndex = 5;
            btnEdytujKsiazke.Text = "Edytuj książkę";
            btnEdytujKsiazke.UseVisualStyleBackColor = true;
            btnEdytujKsiazke.Click += btnEdytujKsiazke_Click;
            // 
            // btnAutorzy
            // 
            btnAutorzy.Location = new Point(0, 313);
            btnAutorzy.Name = "btnAutorzy";
            btnAutorzy.Size = new Size(203, 46);
            btnAutorzy.TabIndex = 6;
            btnAutorzy.Text = "Zarządzaj autorami";
            btnAutorzy.UseVisualStyleBackColor = true;
            btnAutorzy.Click += btnAutorzy_Click;
            // 
            // FormularzGlowny
            // 
            ClientSize = new Size(836, 359);
            Controls.Add(btnAutorzy);
            Controls.Add(btnEdytujKsiazke);
            Controls.Add(btnZmienDostepnosc);
            Controls.Add(btnDodajAutora);
            Controls.Add(btnUsun);
            Controls.Add(dataGridView1);
            Controls.Add(btnDodaj);
            Name = "FormularzGlowny";
            Text = "Biblioteka książek";
            Load += FormularzGlowny_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}
