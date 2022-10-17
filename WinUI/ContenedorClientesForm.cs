using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class ContenedorClientesForm : Form
    {
        public ContenedorClientesForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrearClienteForm crearClienteForm = new CrearClienteForm();
            crearClienteForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RUDClienteForm rUDClienteForm = new RUDClienteForm();
            rUDClienteForm.ShowDialog();
        }
    }
}
