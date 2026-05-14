using ContactosApp.Models;

namespace ContactosApp.ViewModels
{
    public class ContactosViewModel
    {
        public int Id { get; set; }

        public string Contacto { get; set; } = null;

        public string Telefono { get; set; } = null;

        public string Correo { get; set; } = null;

        public int Estado { get; set; }

        public String Tipo { get; set; } = "";

        public static ContactosViewModel MapTo(Contacto ob)
        {
            return new ContactosViewModel()
            {
                Id = ob.IdContactos,
                Contacto = ob.Nombre.ToUpper() + " " + ob.Apellido.ToUpper(),
                Telefono = ob.Telefono,
                Correo = ob.Correo,
                Estado = ob.Estado,
                Tipo = ob.IdTipoNavigation.Nombre.ToUpper()
            };
        }


    }
}
