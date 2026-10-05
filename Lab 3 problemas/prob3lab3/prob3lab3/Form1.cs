using System;
using System.Linq;
using System.Windows.Forms;

namespace prob3lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Form2 ventanaTexto = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            if (ventanaTexto == null)
            {
                ventanaTexto = new Form2();
                ventanaTexto.MdiParent = this;
                ventanaTexto.Show();
            }
            else
            {
                ventanaTexto.BringToFront();
            }
        }
    }
}