using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSesion06
{
    public partial class frmIngresoDeCurso : Form
    {
        cGestionMatricula objMatricula = new cGestionMatricula();
        public frmIngresoDeCurso()
        {
            InitializeComponent();
        }

        private void btnIngresarCurso_Click(object sender, EventArgs e)
        {
            cCurso curso = new cCurso();
            curso.Codigo = txtCodigo.Text;
            curso.Nombre = txtNombreCurso.Text;
            objMatricula.insertarCurso(curso);

            MessageBox.Show("OK");
        }
    }
}
