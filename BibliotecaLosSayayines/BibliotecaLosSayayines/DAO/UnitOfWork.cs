using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.DAO
{
    public class UnitOfWork
    {

        public static LibroDAO libro = new LibroDAO();
        public static CategoriaDAO categoria = new CategoriaDAO();
        public static EditorialDAO editorial = new EditorialDAO();
        public static AutorDAO autor = new AutorDAO();
        public static ClienteDAO cliente = new ClienteDAO();
        public static GeneroDAO genero = new GeneroDAO();
        public static PrestamoDAO prestamo = new PrestamoDAO();
        public static UsuarioDAO usuario = new UsuarioDAO();
        public static DetallePrestamoDAO detallePrestamo = new DetallePrestamoDAO();

    }
}
