using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;
 
namespace MVCLaboratorio.Models
{
    public class RepositorioCurso_Tema : ICurso_Tema
    {
        public List<Curso_Tema> obtenerCurso_Temas()
        {
         //obtener la info de Curso_Tema de la BD
            DataTable dtCurso_Tema;
            dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Tema_ConsultarTodo", CommandType.StoredProcedure);
            List<Curso_Tema> lstCurso_Tema = new List<Curso_Tema>();
            //convertir el DataTable a una lista de Curso_Tema List<Curso_Tema>
            foreach (DataRow item in dtCurso_Tema.Rows)
            {
                Curso_Tema Curso_TemaAux = new Curso_Tema();
                Curso_TemaAux.IdCT = int.Parse(item["IdCT"].ToString());
                Curso_TemaAux.IdCurso= int.Parse(item["IdCurso"].ToString());
                Curso_TemaAux.IdTema = int.Parse(item["IdTema"].ToString());
                lstCurso_Tema.Add(Curso_TemaAux);
            }
            return lstCurso_Tema ;
           
        }

        public Curso_Tema obtenerCurso_Tema(int IdCT)
        {
            throw new NotImplementedException();
        }

        public void insertarCurso_Tema(Curso_Tema datosCurso_Tema)
        {
            throw new NotImplementedException();
        }

        public void eliminarCurso_Tema(int IdCT)
        {
            throw new NotImplementedException();
        }

        public void actualizarCurso_Tema(Curso_Tema datosCurso_Tema)
        {
            throw new NotImplementedException();
        }
    }
}