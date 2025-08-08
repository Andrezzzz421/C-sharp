using EmpresaV1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaV1.DAO
{
    public class EmpleadoDAO
    {
        private static List<Empleado> emp = new List<Empleado>();

        public List<Empleado> GetAll()
        {
            return emp;
        }

        public Empleado GetById(int id)
        {
            foreach(var e in emp)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }

            return null;

        }

        public void Add(Empleado empleado)
        {
            var em = GetById(empleado.Id);
            if (em != null)
            {
                em.Nombre = empleado.Nombre;
                em.Apellido = empleado.Apellido;
                em.DocumentoIdentidad = empleado.DocumentoIdentidad;
                em.FechaNacimiento = empleado.FechaNacimiento;
                em.FechaContratacion = empleado.FechaContratacion;
                em.Salario = empleado.Salario;
                em.Estado = empleado.Estado;
                em.Cargo = empleado.Cargo;
            }
        }

        public void Update(Empleado empleado)
        {
            var em = GetById(empleado.Id);
            if(em != null)
            {
                em.Nombre = empleado.Nombre;
                em.Apellido = empleado.Apellido;
                em.DocumentoIdentidad = empleado.DocumentoIdentidad;
                em.FechaNacimiento = empleado.FechaNacimiento;
                em.FechaContratacion = empleado.FechaContratacion;
                em.Salario = empleado.Salario;
                em.Estado = empleado.Estado;
                em.Cargo = empleado.Cargo;
            }
        }

        public void Delete(int id)
        {
            var em = GetById(id);
            if (em != null)
            {
                emp.Remove(em);
            }
        }
    }
}
