using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.DTO
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public String Nombre { get; set; } = "";
        public int Cantidad { get; set; }

        [DisplayName("Precio Venta")]
        public double PrecioVenta { get; set; }

        [DisplayName("Precio Compra")]
        public double PrecioCompra { get; set; }

        [DisplayName("Categoria")]
        public String NombreCategoria { get; set; } = "";
        public Image Foto { get; set; }


    }
}
