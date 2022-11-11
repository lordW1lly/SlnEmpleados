using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Models.Derivada
{
    public class Departamento
    {
        public Departamento(string id, string nombre, List<Empleado> empleadosList)
        {
            Id = id;
            Nombre = nombre;
            EmpleadosList = empleadosList;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }

        #region prop Navegacion

        public List<Empleado> EmpleadosList { get; set; }

        #endregion

    }
}
