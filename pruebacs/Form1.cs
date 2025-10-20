using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebacs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = tbtNombre.Text;


            if (!string.IsNullOrEmpty(nombre))
            {

                lbLista.Items.Add(nombre);


                lbLista.ClearSelected();
            }
            else
            {
                // Mostrar mensaje si el TextBox está vacío
                MessageBox.Show("Por favor ingrese un nombre.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (lbLista.SelectedIndex != -1)
            {

                lbLista.Items.RemoveAt(lbLista.SelectedIndex);
            }
            else
            {

                MessageBox.Show("Por favor seleccione un nombre para eliminar.");
            }
        }

        private void btnVerTope_Click(object sender, EventArgs e)
        {
            // Verifica si hay elementos en la lista
            if (lbLista.Items.Count > 0)
            {
                // Obtener el primer nombre (índice 0)
                string primerNombre = lbLista.Items[0].ToString();

                // Mostrar en un MessageBox
                MessageBox.Show("El primer nombre es: " + primerNombre);
            }
            else
            {
                // Si la lista está vacía
                MessageBox.Show("La lista está vacía.");
            }
        }


    }
}

