using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Models.Base
{
    public abstract class Persona
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
