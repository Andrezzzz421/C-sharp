using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculo.DAO;
using TallerVehiculo.Model;

namespace TallerVehiculo.Helpers
{
    public class APHelper
    {
        private static MarcaDAO mDAO  = new MarcaDAO();
        private static PropietarioDAO prDAO = new PropietarioDAO();
        private static VehiculoDAO vDAO = new VehiculoDAO();

        public static void Seed()
        {
            Marca ob0 = new Marca()
            {
                Id = 0,
                Nombre = "Seleccione la marca",
                PaisOrigen = "",
                FechaCreacion = DateTime.Parse("10-10-2020")
            };

            Marca ob1 = new Marca()
            {
                Id = 1,
                Nombre = "Ford",
                PaisOrigen = "USA",
                FechaCreacion = DateTime.Parse("10-10-2020")

            };

            Marca ob2 = new Marca()
            {
                Id = 2,
                Nombre = "Toyota",
                PaisOrigen = "Japon",
                FechaCreacion = DateTime.Parse("11-1-2020")
            };
            Marca ob3 = new Marca()
            {
                Id = 3,
                Nombre = "Renault",
                PaisOrigen = "Francia",
                FechaCreacion = DateTime.Parse("1-2-2020")
            };
            mDAO.Add(ob0);
            mDAO.Add(ob1);
            mDAO.Add(ob2);
            mDAO.Add(ob3);

            Propietario p0 = new Propietario()
            {
                Id = 0,
                Nombre = "Seleccione el Propietario",
                Correo = "",
                Direccion = "",
                Telefono = "",
                FechaNacimiento = DateTime.Parse("10-10-1910"),
                FechaCreacion = DateTime.Parse("10-10-2020")
            };

            Propietario p1 = new Propietario()
            {
                Id = 1010,
                Nombre = "Wilmer J. Manotas",
                Correo = "wilmerj@gmail.com",
                Direccion = "cra 10",
                Telefono = "12345",
                FechaNacimiento = DateTime.Parse("10-10-1910"),
                FechaCreacion = DateTime.Parse("10-10-2020")
            };

            Propietario p2 = new Propietario()
            {
                Id = 2020,
                Nombre = "Erika Mendez",
                Correo = "emendez@gmail.com",
                Direccion = "cra 122",
                Telefono = "122222",
                FechaNacimiento = DateTime.Parse("12-12-1915"),
                FechaCreacion = DateTime.Parse("10-10-2020")
            };
            prDAO.Add(p0);
            prDAO.Add(p1);
            prDAO.Add(p2);

            Vehiculo v1 = new Vehiculo()
            {
                Placa = "abc-123",
                Color = "Rojo",
                Foto = "",
                IdMarca = 1,
                IdPropietario = 1010,
                Modelo = "ABC",
                AnioProduccion = 2020,
                FechaCreacion = DateTime.Parse("10-10-2020")
            };
            Vehiculo v2 = new Vehiculo()
            {
                Placa = "xyz-123",
                Color = "Azul",
                Foto = "",
                IdMarca = 2,
                IdPropietario = 1010,
                Modelo ="JJ1",
                AnioProduccion = 2000,
                FechaCreacion = DateTime.Parse("1-4-2020")
            };
            Vehiculo v3 = new Vehiculo
            {
                Placa = "xyz-123",
                Color = "Azul",
                Foto = "",
                IdMarca = 2,
                IdPropietario = 1010,
                Modelo = "JJ1",
                AnioProduccion = 2000,
                FechaCreacion = DateTime.Parse("1-4-2020")
            };
            vDAO.Add(v1);
            vDAO.Add(v2);
            vDAO.Add(v3);
        }
    }
}
