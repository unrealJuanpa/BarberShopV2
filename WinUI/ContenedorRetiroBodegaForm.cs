﻿using System;
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
    public partial class ContenedorRetiroBodegaForm : Form
    {
        public ContenedorRetiroBodegaForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrearRetiroBodegaForm crearRetiroBodegaForm = new CrearRetiroBodegaForm();
            crearRetiroBodegaForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RUDRetiroBodegaForm rUDRetiroBodegaForm = new RUDRetiroBodegaForm();
            rUDRetiroBodegaForm.ShowDialog();
        }
    }
}
