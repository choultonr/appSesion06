using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSesion06
{
    public class cGestionMatricula
    {
        //Lista de cursos donde un alumno se puede matricular: lista general de cursos disponibles
        //static: 
        
        public List<cCurso> Cursos { get; set; }

        public cGestionMatricula()
        {
            if (Cursos == null)
            //Crear la lista
            Cursos = new List<cCurso>();
        }

        public void insertarCurso(cCurso curso)
        {
            Cursos.Add(curso);
        }

        public void insertarAlumnoEnCurso(string codigo_curso,cAlumno alumno)
        {
            cCurso curso_encontrado=Cursos.Find(delegate (cCurso value) {
                return value.Codigo == codigo_curso;
            });

            if (curso_encontrado != null)
                curso_encontrado.Alumnos.Add(alumno);
        }

        public List<cAlumno> listarAlumnosDeCurso(string codigo_curso)
        {
            cCurso curso_encontrado=Cursos.Find(delegate (cCurso value) {
                return value.Codigo == codigo_curso;
            });

            if (curso_encontrado != null)
                return curso_encontrado.Alumnos;
            else
                return null;
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
