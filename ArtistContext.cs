using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Application
{
    public partial class ArtistContext : DbContext
    {
        public ArtistContext()
        {

        }
        public ArtistContext(DbContextOptions<musicContext> options) : base(options)
        {

        }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Album_song> AlbumsSongs { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NB24L70;Initial Catalog=music;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {


                entity.HasKey(e => e.Album_ID);

                entity.Property(e => e.Album_ID)
                    .HasColumnName("AlbumId");

                entity.Property(e => e.Artist_ID)
                    .HasColumnName("ArtistId");

                entity.Property(e => e.Album_Year)
                    .HasColumnName("AlbumYear");

               

                entity.HasOne(d => d.IdArtistNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ArtistId);
            });
            modelBuilder.Entity<AlbumSongs>(entity =>
            {
                entity.HasKey(e => new { e.AlbumId, e.SongId });

                entity.Property(e => e.AlbumId)
                    .HasColumnName("AlbumId");

                entity.Property(e => e.SongId)
                    .HasColumnName("Song_id");

          

                entity.HasOne(d => d.IdAlbumNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.AlbumId);

                entity.HasOne(d => d.IdSongNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.SongId);
            });
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.ArtitId);

                entity.Property(e => e.ArtitId)
                    .HasColumnName("ArtistId");

                entity.Property(e => e.GenreId)
                    .HasColumnName("GenreId");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryId");

                entity.Property(e => e.Artist_Site_URL)
                    .IsUnicode(false)
                    .HasColumnName("Artist_Site_URL");

                entity.HasOne(d => d.IdGenreNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.GenreId);

                entity.HasOne(d => d.IdCountryNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.CountryId);
            });
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_id");

                entity.Property(e => e.CountryName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CountryName");

            });
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenreId);

                entity.Property(e => e.GenreId)
                    .HasColumnName("GenreId");

                entity.Property(e => e.GenreName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GenreName");
            });
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.ArtistId);

                entity.Property(e => e.ArtistId)
                    .HasColumnName("ArtistId");

                entity.Property(e => e.Group_Name)
                    .HasColumnName("GroupName");

                entity.HasOne(d => d.IdArtistNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.ArtistId);
            });
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.ArtistId);

                entity.Property(e => e.ArtistId)
                    .HasColumnName("ArtistId");

                entity.Property(e => e.First_Name)
                    .HasColumnName("First_name");

                entity.Property(e => e.Last_Name)
                    .HasColumnName("Last_name");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("Birthday");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sex");

                entity.HasOne(d => d.IdArtistNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.ArtistId);
            });
            modelBuilder.Entity<Song>(entity =>
            {
                entity.HasKey(e => e.SongId);

                entity.Property(e => e.SongId)
                    .HasColumnName("Song_id");

                entity.Property(e => e.Song_Title)
                    .HasColumnName("Song_Title");

                entity.Property(e => e.Song_Duration)
                    .HasColumnName("Song_Duration");

            });
           OnModelCreatingPartial(modelBuilder);
    }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
