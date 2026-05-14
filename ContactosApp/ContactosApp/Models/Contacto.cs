using System;
using System.Collections.Generic;

namespace ContactosApp.Models;

public partial class Contacto
{
    public int IdContactos { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int Estado { get; set; }

    public int IdTipo { get; set; }

    public virtual Tipo IdTipoNavigation { get; set; } = null!;
}
