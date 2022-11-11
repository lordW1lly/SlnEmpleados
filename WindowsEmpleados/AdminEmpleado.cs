﻿using LibreriaEmpleado.Models.Models.Derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;

namespace WindowsEmpleados
{
    public static  class AdminEmpleado
    {
        static DbEmpleadosContext context = new DbEmpleadosContext();
        public static List<Empleado> Lista()
        {
            List<Empleado> listEmpleados = context.Empleados.ToList();
            return listEmpleados;

        }

        public static int Insertar(Empleado empleado)
        {
            context.Empleados.Add(empleado);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

    }
}
