using System;
using System.Linq;
using System.Windows.Forms;

namespace FormularioMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 ventana = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            if (ventana != null)
            {
                ventana.BringToFront();
                ventana.Focus();
            }
            else
            {
                ventana = new Form2();
                ventana.MdiParent = this;
                ventana.Show();
            }
        }
    }
}