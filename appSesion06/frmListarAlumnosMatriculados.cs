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
    public partial class frmListarAlumnosMatriculados : Form
    {
        public frmListarAlumnosMatriculados()
        {
            InitializeComponent();
        }

        private void frmListarAlumnosMatriculados_Load(object sender, EventArgs e)
        {
            lbCursos.DisplayMember = "Nombre";
            lbCursos.ValueMember = "Código";
            lbCursos.DataSource = cGestionMatricula.Cursos;
        }

        private void lbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Metodo selectedItem, recuperar un elemento seleccionado del
            //listBox
            cCurso curso=(cCurso)lbCursos.SelectedItem;
            lbAlumnos.DisplayMember = "NombreCompleto";
            lbAlumnos.ValueMember = "TIU";
            lbAlumnos.DataSource = curso.Alumnos;
        }
    }
}
