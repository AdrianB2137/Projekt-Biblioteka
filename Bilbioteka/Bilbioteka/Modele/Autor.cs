
namespace BibliotekaNet8.Modele
{
    public class Autor
    {
        public int Id { get; set; }
        public string ImieNazwisko { get; set; }

        public ICollection<Ksiazka> Ksiazki { get; set; }
    }
}
