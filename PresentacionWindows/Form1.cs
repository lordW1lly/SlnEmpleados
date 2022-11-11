using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEmpleado.Models.Models.Base;
using LibreriaEmpleado.Models.Models.Derivada;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnCargarDpto_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            Empleado emplado1 = new Empleado() { Nombre = "Pedro", Apellido = "Martinez", ID = "02221", Legajo = "PM001", };
            Empleado empleado2 = new Empleado() { Nombre = "Juan", Apellido = "Viera", Legajo = "JV001", ID = "0035" };
            Empleado empleado3 = new Empleado() { Nombre = "Paula", Apellido = "Roldan", ID = "JR001", Legajo = "00123" };
            empleados.Add(emplado1);
            empleados.Add(empleado3);
            empleados.Add(empleado2);


            Departamento departamento = new Departamento("F001", "Finanzas", empleados);
            dataGridView1.DataSource = departamento.EmpleadosList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bttnVerEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
