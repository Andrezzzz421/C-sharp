using System;
using System.Collections.Generic;

namespace BibliotecaFInal.Models;

public partial class Editoriale
{
    public int IdEditorial { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int? IdPais { get; set; }

    public virtual Paise? IdPaisNavigation { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
