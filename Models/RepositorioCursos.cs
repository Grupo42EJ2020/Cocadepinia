using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioCursos : ICurso
    {
        public List<Cursos> obtenerCurso()
        { 
            DataTable dtCursos;
            dtCursos = BaseHelper.ejecutarConsulta("Sp_ConsultarTodo_Curso", CommandType.StoredProcedure);
            List<Cursos> lstCursos = new List<Cursos>();

             foreach (DataRow item in dtCursos.Rows)
            {
                Cursos CursosA = new Cursos();
                CursosA.IdCursos = int.Parse(item["IdCurso"].ToString());
                CursosA.Descripcion = item["Descripcion"].ToString();
                CursosA.IdEmpleado = int.Parse(item["IdEmpleado"].ToString());
                lstCursos.Add(CursosA);
            }

            return lstCursos;
        }

        public Cursos obtenerCurso(int IdCurso)
        {
            DataTable dtCursos;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", IdCurso));

            dtCursos = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Cursos datosCursos = new Cursos();

            if (dtCursos.Rows.Count > 0)
            {
                datosCursos.IdCursos = int.Parse(dtCursos.Rows[0]["IdCurso"].ToString());
                datosCursos.Descripcion = dtCursos.Rows[0]["Descripcion"].ToString();
                datosCursos.IdEmpleado = int.Parse(dtCursos.Rows[0]["Direccion"].ToString());

                return datosCursos;
            }
            else
            {
                return null;
            }
        }

        public void insertarCurso(Cursos datosCursos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Descripcion", datosCursos.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCursos.IdEmpleado));

            BaseHelper.ejecutarConsulta("sp_Empleado_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarCurso(int IdCurso)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", IdCurso));

            BaseHelper.ejecutarSentencia("sp_Empleado_Eliminar", CommandType.StoredProcedure, parametros);

        }

        public void actualizarCurso(Cursos datosCursos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", datosCursos.IdCursos));
            parametros.Add(new SqlParameter("@Descripcion", datosCursos.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCursos.IdEmpleado));

            BaseHelper.ejecutarConsulta("sp_Empleado_Actualizar", CommandType.StoredProcedure, parametros);

        } 

        }

    }
