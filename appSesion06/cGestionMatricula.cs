using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSesion06
{
    public class cGestionMatricula
    {
        //Lista de cursos donde un alumno se puede matricular:lista general de cursos
        //static: 
        

        public cGestionMatricula()
        {
            
        }

        public void insertarCurso(cCurso curso)
        {
            
        }

        public void insertarAlumnoEnCurso(string codigo_curso,cAlumno alumno)
        {
            
        }

        public List<cAlumno> listarAlumnosDeCurso(string codigo_curso)
        {
            
        }

        public cCurso dameCursoConMasAlumnos()
        {
            cCurso temp = new cCurso();
            foreach( cCurso curso in Cursos)
            {
                if (curso.Alumnos.Count > temp.Alumnos.Count)
                    temp = curso;
            }
            return temp;
        }


        

    }
}
