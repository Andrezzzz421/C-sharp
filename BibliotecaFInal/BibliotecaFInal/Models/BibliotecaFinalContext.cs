using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFInal.Models;

public partial class BibliotecaFinalContext : DbContext
{
    public BibliotecaFinalContext()
    {
    }

    public BibliotecaFinalContext(DbContextOptions<BibliotecaFinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Editoriale> Editoriales { get; set; }

    public virtual DbSet<Ejemplare> Ejemplares { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK__Autores__DD33B0314BB6B064");

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Genero).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.IdPaisOrigenNavigation).WithMany(p => p.Autores)
                .HasForeignKey(d => d.IdPaisOrigen)
                .HasConstraintName("FK__Autores__IdPaisO__398D8EEE");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__A3C02A10C8F1C7AC");

            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Editoriale>(entity =>
        {
            entity.HasKey(e => e.IdEditorial).HasName("PK__Editoria__EF838671A488E5B1");

            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(150);

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Editoriales)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("FK__Editorial__IdPai__3E52440B");
        });

        modelBuilder.Entity<Ejemplare>(entity =>
        {
            entity.HasKey(e => e.IdEjemplar).HasName("PK__Ejemplar__DE7E44BBEC5F618B");

            entity.Property(e => e.CodigoInventario).HasMaxLength(100);
            entity.Property(e => e.Estado).HasMaxLength(20);

            entity.HasOne(d => d.IdLibroNavigation).WithMany(p => p.Ejemplares)
                .HasForeignKey(d => d.IdLibro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ejemplare__IdLib__46E78A0C");
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("PK__Libros__3E0B49ADABB4E5B8");

            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasColumnName("ISBN");
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdAutor)
                .HasConstraintName("FK__Libros__IdAutor__412EB0B6");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Libros__IdCatego__4222D4EF");

            entity.HasOne(d => d.IdEditorialNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdEditorial)
                .HasConstraintName("FK__Libros__IdEditor__4316F928");
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PK__Paises__FC850A7BB1CA1971");

            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
