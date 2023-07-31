using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEscuelita
{
    public partial class Form1 : Form
    {
        public Escuelas escuelas = new Escuelas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "Felicidad" && txtUsuario.Text == "RegistroUnico")
            {
                RegistroNuevo registrar = new RegistroNuevo();
                registrar.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Datos Ingresados Incorrectos");
                txtUsuario.Text = "";
                txtClave.Text = " ";
            }
        }
    }
}
