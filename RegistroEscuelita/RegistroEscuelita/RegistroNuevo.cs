using System;
using System.Windows.Forms;

namespace RegistroEscuelita
{
    public partial class RegistroNuevo : Form
    {
        public Escuelas escuelas = new Escuelas();
        public RegistroNuevo()
        {

            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Escuela escuela = new Escuela();
            escuela.NombresB = txtNombresB.Text;
            escuela.ApellidosB = txtApellidosB.Text;
            escuela.CedulaB = Convert.ToInt32(mtxtCedulaN.Text);
            escuela.Genero = cmbGenero.Text;
            escuela.Edad = Convert.ToInt32(mtxtEdad.Text);
            escuela.NombresP = txtNombreP.Text;
            escuela.Celular = Convert.ToInt32(mtxtCelularP.Text);
            escuela.CedulaP = Convert.ToInt32(mtxtCedula.Text);
            escuela.Curso = cmbGrado.Text;
            escuelas.AgregarNinos(escuela);
            MessageBox.Show("Sus datos fueron guardados con exito");
            dgvDatos.DataSource = escuelas.ImprimirNinos();
            Limpiar();
           
        }
        private void Limpiar()
        {
            txtNombresB.Text = " ";
            txtApellidosB.Text = " ";
            mtxtCedulaN.Text = " ";
            cmbGenero.Text = " ";
            mtxtEdad.Text = " ";
            txtNombreP.Text = " ";
            mtxtCelularP.Text = " ";
            mtxtCedula.Text = " ";
            mtxtCelularP.Text = " ";
            cmbGrado.Text = " ";

        }
        
    }
}
