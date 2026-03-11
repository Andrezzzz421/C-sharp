using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace productodb.Models;

public partial class Producto
{
    public int Id { get; set; }

    [Required(ErrorMessage ="El campo {0} es obligatorio.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [RegularExpression("^[0-9]*$",ErrorMessage ="El campo {0} solo acepta numeros.")]
    public int Cantidad { get; set; }

    [DisplayName("Precio de Compra")]
    [Required(ErrorMessage ="El campo {0} es obligatorio.")]
    [RegularExpression("^[0-9]*$",ErrorMessage ="El campo {0} solo acepta numeros.")]
    public decimal Preciocompra { get; set; }

    [Required(ErrorMessage ="El campo {0} es obligatorio.")]
    public string Categoria { get; set; }
}
