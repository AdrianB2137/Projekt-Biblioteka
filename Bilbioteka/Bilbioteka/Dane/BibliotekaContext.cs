using Microsoft.EntityFrameworkCore;
using BibliotekaNet8.Modele;

namespace BibliotekaNet8.Dane
{
    public class BibliotekaContext : DbContext
    {
        public BibliotekaContext(DbContextOptions<BibliotekaContext> options)
            : base(options)
        {
        }

        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Autor> Autorzy { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Ksiazka>(entity =>
            {
                entity.ToTable("ksiazki");
                entity.Property(e => e.DataWydania)
                    .HasColumnName("datawydania")
                    .HasColumnType("timestamp without time zone");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Tytul).HasColumnName("tytul");
                entity.Property(e => e.AutorId).HasColumnName("autorid");
                entity.Property(e => e.DataWydania).HasColumnName("datawydania");
                entity.Property(e => e.Dostepna).HasColumnName("dostepna");

                entity.HasOne(e => e.Autor)
                      .WithMany(a => a.Ksiazki)
                      .HasForeignKey(e => e.AutorId);
            });

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.ToTable("autorzy");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.ImieNazwisko).HasColumnName("imienazwisko");
            });
        }
    }
}
