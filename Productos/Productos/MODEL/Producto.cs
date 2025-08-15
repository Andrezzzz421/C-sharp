using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.MODEL
{
    public class Producto
    {
        public int Id { get; set; }
        public String Nombre { get; set; } = "";
        public int Cantidad { get; set; }
        public double PrecioCompra {  get; set; }
        public double PrecioVenta {  get; set; }
        public int Categoria { get; set; }
        public bool Disponible { get; set; } = true;

        public String Foto { get; set; } = "";
    }
}
