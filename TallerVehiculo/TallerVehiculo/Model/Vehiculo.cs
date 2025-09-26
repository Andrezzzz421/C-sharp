using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculo.Model
{
    public class Vehiculo
    {
        public String Placa { get; set; } = "";
        public string Color { get; set; } = "";
        [DisplayName("Año de Produccíon")]
        public int AnioProduccion { get; set; } = 0;
        public string Modelo { get; set; } = "";
        public string Foto { get; set; } = "";
        public int IdPropietario { get; set; } 
        public int IdMarca { get; set; }
        public DateTime FechaCreacion {  get; set; }
    }
}
