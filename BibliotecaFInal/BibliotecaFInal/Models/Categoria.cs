using System;
using System.Collections.Generic;

namespace BibliotecaFInal.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public byte[]? Logo { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
