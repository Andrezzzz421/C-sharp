using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculo.DTO
{
    public class VehiculoDTO
    {
        public string Placa { get; set; }
        public string Color { get; set; } = "";

        [DisplayName("Año de Produccíon")]
        public int AnioProduccion { get; set; } = 0;
        public string Modelo { get; set; } = "";
        public String Marca { get; set; } = "";
        public string Propietario { get; set; } = "";
    }
}
