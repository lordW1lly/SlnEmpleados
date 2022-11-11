using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEmpleado.Models.Models.Base;

namespace LibreriaEmpleado.Models.Models.Derivada
{
    public class Cliente : Persona
    {
       public string Cuit { get; set; }
       public string Telefono { get; set; }
    
    }
}
