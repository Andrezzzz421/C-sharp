using System;
using System.Collections.Generic;

namespace BibliotecaFInal.Models;

public partial class Ejemplare
{
    public int IdEjemplar { get; set; }

    public int IdLibro { get; set; }

    public string CodigoInventario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual Libro? IdLibroNavigation { get; set; } = null!;
}
