using LibreriaEmpleado.Models.Models.Derivada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEmpleados.Data;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
        DbEmpleadosContext context = new DbEmpleadosContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Empleado emplado1 = new Empleado() { Nombre = "Pedro", Apellido = "Martinez", ID = "02221", Legajo = "PM001", };
            Empleado empleado2 = new Empleado() { Nombre = "Juan", Apellido = "Viera", Legajo = "JV001", ID = "0035" };
            Empleado empleado3 = new Empleado() { Nombre = "Paula", Apellido = "Roldan", ID = "JR001", Legajo = "00123" };
            AdminEmpleado.Insertar(emplado1);
            AdminEmpleado.Insertar(empleado2);
            AdminEmpleado.Insertar(empleado3);
            if(context.SaveChanges() > 1)
            {
                MessageBox.Show("Empleados creados con exito");
            }
        }

        private void bttnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Empleados.ToList();

        }
    }
}
