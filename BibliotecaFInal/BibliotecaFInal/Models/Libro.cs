using System;
using System.Collections.Generic;

namespace BibliotecaFInal.Models;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Titulo { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string? Sinopsis { get; set; }

    public byte[]? Portada { get; set; }

    public int AnioPublicacion { get; set; }

    public decimal Precio { get; set; }

    public int? IdAutor { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdEditorial { get; set; }

    public virtual ICollection<Ejemplare> Ejemplares { get; set; } = new List<Ejemplare>();

    public virtual Autore? IdAutorNavigation { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Editoriale? IdEditorialNavigation { get; set; }
}
