using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int chequeo = 0;
            string apellido = txtApellido.Text;
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                chequeo++;
            }
            string nombre = txtNombre.Text;
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                chequeo++;
            }
            string edad = "EDAD: " + txtEdad.Text;
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }
            else
            {
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
                chequeo++;
            }
            string direccion = "DIRECCION: " + txtDireccion.Text;
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
                chequeo++;
            }
            
            if (chequeo == 4)
            {
                //string datos = apellido + " " + nombre + " " + edad + " " + direccion;
                string datos = "APELLIDO Y NOMBRE: " + apellido + " " + nombre;
                lwPersonas.Items.Add(datos);
                lwPersonas.Items.Add(edad);
                lwPersonas.Items.Add(direccion);
            }
            else
            {
                MessageBox.Show("SE TIENEN QUE AGREGAR TODOS LOS DATOS");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
