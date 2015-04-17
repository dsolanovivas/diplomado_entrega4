using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objetos
{
    public partial class Form1 : Form
    {
        Persona nueva;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nueva = new Persona(int.Parse(spnedad.Value.ToString()), txtnombre.Text);
            if (nueva.Edad >= 18)
            {
                MessageBox.Show("La edad de " + nueva.Nombre + " tiene " + nueva.Edad.ToString()
                    + " es mayor de 18 años");
            }
            else
            {
                MessageBox.Show("La edad de " + nueva.Nombre + " tiene " + nueva.Edad.ToString()
                     + " es menor de 18 años");
            }

        }
    }
}
