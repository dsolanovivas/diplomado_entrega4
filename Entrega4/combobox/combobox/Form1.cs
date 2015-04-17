using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int cont = 0; cont <= 255; cont++)
            {
                cbxrojo.Items.Add(cont.ToString());
                cbxverde.Items.Add(cont.ToString());
                cbxazul.Items.Add(cont.ToString());
                
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(int.Parse(cbxrojo.Text), int.Parse(cbxverde.Text), int.Parse(cbxazul.Text));
        }
    }
}
