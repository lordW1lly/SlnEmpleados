using LibreriaEmpleado.Models.Models.Derivada;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmpleados.Data
{
    public class DbEmpleadosContext : DbContext

    {
        public DbEmpleadosContext() : base("keyEmpleadosDB") {}

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

    }
}
