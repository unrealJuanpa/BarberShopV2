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
    public partial class ContenedorRegistroAplicacionForm : Form
    {
        public ContenedorRegistroAplicacionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RUDRegistroAplicacionForm rUDRegistroAplicacionForm = new RUDRegistroAplicacionForm();
            rUDRegistroAplicacionForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrearRegistroAplicacionForm crearRegistroAplicacionForm = new CrearRegistroAplicacionForm();
            crearRegistroAplicacionForm.ShowDialog();
        }
    }
}
