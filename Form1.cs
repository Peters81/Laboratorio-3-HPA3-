using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EjemploGrid
{
    public partial class Form1 : Form
    {

        List<Persona> listaPersonas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Persona miColaborador = new Persona();

            miColaborador.Id = 1;
            miColaborador.Nombres = "Elena Carolina";
            miColaborador.Apellidos = "Gonzalez Rodríguez";
            miColaborador.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador.FechaNacimiento = new DateTime(1990, 5, 15);

            listaPersonas.Add(miColaborador);
            dgvdatos.DataSource = listaPersonas;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text == "")
            {
                errorProvider1.SetError(txtIdEmpleado, "El campo ID es obligatorio");
                txtIdEmpleado.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtIdEmpleado, "");
            }

  
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "El campo Nombre es obligatorio");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "El campo Apellido es obligatorio");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }

            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "El campo Email es obligatorio");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
            
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(dateTimePicker1, "La fecha de nacimiento no puede ser mayor a la actual");
                dateTimePicker1.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario <= 0)
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido mayor a 0");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            Persona miColaborador = new Persona();
            miColaborador.Id = int.Parse(txtIdEmpleado.Text);
            miColaborador.Nombres = txtNombre.Text;
            miColaborador.Apellidos = txtApellido.Text;
            miColaborador.Correo = txtEmail.Text;
            miColaborador.FechaNacimiento = dateTimePicker1.Value;
            miColaborador.Salario = salario;

          
            listaPersonas.Add(miColaborador);
            dgvdatos.DataSource = null;
            dgvdatos.DataSource = listaPersonas;
        }
    }
}