using System;
using System.Collections.Generic;

namespace BibliotecaFInal.Models;

public partial class Paise
{
    public int IdPais { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Autore> Autores { get; set; } = new List<Autore>();

    public virtual ICollection<Editoriale> Editoriales { get; set; } = new List<Editoriale>();
}
