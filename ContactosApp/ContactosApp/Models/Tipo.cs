using System;
using System.Collections.Generic;

namespace ContactosApp.Models;

public partial class Tipo
{
    public int IdTipo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();
}
