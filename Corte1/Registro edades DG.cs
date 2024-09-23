using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Corte1
{
    public partial class Form1 : Form
    {
        // Instancia de Registro para almacenar las personas
        private Registro registro;

        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar ComboBox con las ciudades deseadas
            cbCities.Items.AddRange(new string[] { "Managua", "Granada", "Estelí" });
            if (cbCities.Items.Count > 0)
                cbCities.SelectedIndex = 0;

            // Configurar el DateTimePicker a la fecha actual
            dateTimePicker1.Value = DateTime.Now;

            
            this.Text = "Registro de edades - DG"; 
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Verificacion ciudad
            if (cbCities.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una ciudad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear la persona 
            Persona persona = new Persona(
                tbName.Text,
                tbLastName.Text,
                dateTimePicker1.Value,
                cbCities.SelectedItem.ToString()
            );

            // Agregamos la persona
            bool agregado = registro.AgregarPersona(persona);

            // Verificación
            if (agregado)
            {
                // Mostrar los detalles en el ListBox
                lbShow.Items.Add($"{persona.Nombres} {persona.Apellidos}, {Operacion.CalcularEdad(persona.FechaNacimiento)} años, Ciudad: {persona.Ciudad}");
                MessageBox.Show("Persona agregada exitosamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("El registro está lleno. No se puede agregar más personas.");
            }
        }

        private void btnAddAge_Click(object sender, EventArgs e)
        {
          
            if (registro.ObtenerPersonas().Count == 0)
            {
                MessageBox.Show("No hay personas registradas para calcular la edad.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            if (lbShow.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una persona de la lista para calcular su edad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            int index = lbShow.SelectedIndex;
            Persona personaSeleccionada = registro.ObtenerPersonas()[index];

            // Calcular la edad utilizando la clase Operacion
            int edad = Operacion.CalcularEdad(personaSeleccionada.FechaNacimiento);
            bool esMayor = Operacion.EsMayorDeEdad(edad);

            // Mostrar el resultado
            string mensaje = $"{personaSeleccionada.Nombres} {personaSeleccionada.Apellidos} tiene {edad} años y es {(esMayor ? "mayor" : "menor")} de edad.";
            MessageBox.Show(mensaje, "Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Limpiamos
        private void LimpiarCampos()
        {
            tbName.Clear();
            tbLastName.Clear();
            dateTimePicker1.Value = DateTime.Now; // Restablecer a la fecha actual
            if (cbCities.Items.Count > 0)
                cbCities.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Limpiar ListBox 
            lbShow.Items.Clear();

            // Obtener la lista 
            var personas = registro.ObtenerPersonas();

            // Verificar si hay personas registradas
            if (personas.Count == 0)
            {
                MessageBox.Show("No hay personas registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Recorrer la lista y añadir cada persona al ListBox
            foreach (var persona in personas)
            {
                lbShow.Items.Add($"{persona.Nombres} {persona.Apellidos}, Ciudad: {persona.Ciudad}, Fecha de Nacimiento: {persona.FechaNacimiento.ToShortDateString()}");
            }
        }
    }
}

