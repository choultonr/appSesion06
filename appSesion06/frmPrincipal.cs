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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ingresoDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoDeCurso frm = new frmIngresoDeCurso();
            frm.ShowDialog();
        }

        private void ingresoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoAlumno frm = new frmIngresoAlumno();
            frm.ShowDialog();
        }

        private void listarAlumnosMatriculadosEnUnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarAlumnosMatriculados frm = new frmListarAlumnosMatriculados();
            frm.ShowDialog();
        }

        private void cursosConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cGestionMatricula objMatricula = new cGestionMatricula();
            cCurso curso=objMatricula.dameCursoConMasAlumnos();
            MessageBox.Show(curso.Nombre);
        }
    }
}
