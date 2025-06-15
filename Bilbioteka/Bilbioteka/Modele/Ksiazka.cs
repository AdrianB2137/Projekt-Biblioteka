
namespace BibliotekaNet8.Modele
{
    public class Ksiazka
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public int AutorId { get; set; }
        public DateTime DataWydania { get; set; }
        public bool Dostepna { get; set; }

        public Autor Autor { get; set; }
    }
}
