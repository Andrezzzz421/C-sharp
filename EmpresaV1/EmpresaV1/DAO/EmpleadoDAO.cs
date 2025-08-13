using EmpresaV1.DTO;
using EmpresaV1.HELPER;
using EmpresaV1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaV1.DAO
{
    public class EmpleadoDAO
    {
        public static List<Empleado> empleados = new List<Empleado>();

        public  List<Empleado> GetAll()
        {
            return empleados;
        }

        public Empleado GetById(int id)
        {
            foreach(var e in empleados)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }

            return null;

        }

        public void Add(Empleado emp)
        {
            var em = GetById(emp.Id);
            if (em == null)
            {
                empleados.Add(emp); 
            }
            else
            {
                em.Nombre = emp.Nombre;
                em.Apellido = emp.Apellido;
                em.DocumentoIdentidad = emp.DocumentoIdentidad;
                em.FechaNacimiento = emp.FechaNacimiento;
                em.FechaContratacion = emp.FechaContratacion;
                em.Salario = emp.Salario;
                em.Estado = emp.Estado;
                em.Cargo = emp.Cargo;
                em.Foto = emp.Foto;
            }
        }

        public void Update(Empleado emp)
        {
            var em = GetById(emp.Id);
            if(em != null)
            {
                em.Nombre = emp.Nombre;
                em.Apellido = emp.Apellido;
                em.DocumentoIdentidad = emp.DocumentoIdentidad;
                em.FechaNacimiento = emp.FechaNacimiento;
                em.FechaContratacion = emp.FechaContratacion;
                em.Salario = emp.Salario;
                em.Estado = emp.Estado;
                em.Cargo = emp.Cargo;
                em.Foto = emp.Foto;
            }
        }

        public void Delete(int id)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                empleados.Remove(emp);
            }
        }

        public List<EmpleadosDTO> GetDTO()
        {
            List<EmpleadosDTO> l2 = new List<EmpleadosDTO>();
            var ls = GetAll();
            foreach (var x in ls)
                l2.Add(EMHelpers.ToDTO(x.Id));
            return l2;
        }
    }
}
