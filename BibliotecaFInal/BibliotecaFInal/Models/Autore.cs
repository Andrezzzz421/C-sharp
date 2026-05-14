using System;
using System.Collections.Generic;

namespace BibliotecaFInal.Models;

public partial class Autore
{
    public int IdAutor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public byte[]? Foto { get; set; }

    public string Genero { get; set; } = null!;

    public int? IdPaisOrigen { get; set; }

    public virtual Paise? IdPaisOrigenNavigation { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
