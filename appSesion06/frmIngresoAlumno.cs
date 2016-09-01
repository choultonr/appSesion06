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
    public partial class frmIngresoAlumno : Form
    {
        cGestionMatricula objMatricula = new cGestionMatricula();

        public frmIngresoAlumno()
        {
            InitializeComponent();
        }

        private void frmIngresoAlumno_Load(object sender, EventArgs e)
        {
            lbCursos.DisplayMember = "Nombre";
            lbCursos.ValueMember = "Código";
            lbCursos.DataSource =cGestionMatricula.Cursos;
        }

        private void btnIngresarAlumno_Click(object sender, EventArgs e)
        {
            cAlumno alumno = new cAlumno();
            alumno.TIU = int.Parse(textBox1.Text);
            alumno.NombreCompleto = textBox2.Text;

            //asignar el curso que selecciona del Listbox(lbCurso) al alumnos
            foreach( cCurso curso in lbCursos.SelectedItems)
            {
                objMatricula.insertarAlumnoEnCurso(curso.Codigo, alumno);
            }

        }
    }
}
