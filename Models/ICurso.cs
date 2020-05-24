using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface ICurso
    {
        List<Cursos> obtenerCurso();
        Cursos obtenerCurso(int IdCurso);
        void insertarCurso(Cursos datosCursos);
        void eliminarCurso(int IdCurso);
        void actualizarCurso(Cursos datosCursos);
    }
}