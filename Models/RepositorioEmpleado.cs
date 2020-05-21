using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioEmpleado : IEmpleado
    {

        public List<Empleado> obtenerEmpleado()
        {
            DataTable dtEmpleado;
            dtEmpleado = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarTodo", CommandType.StoredProcedure);

            List<Empleado> lstEmpleado = new List<Empleado>();

            foreach (DataRow item in dtEmpleado.Rows)
            {
                Empleado EmpleadoA = new Empleado();
                EmpleadoA.IdEmpleado = int.Parse(item["IdEmpleado"].ToString());
                EmpleadoA.Nombre = item["Nombre"].ToString();
                EmpleadoA.Direccion = item["Direccion"].ToString();
                lstEmpleado.Add(EmpleadoA);
            }

            return lstEmpleado;
        }

        public Empleado obtenerEmpleado(int IdEmpleado)
        {
            DataTable dtEmpleado;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", IdEmpleado));

            dtEmpleado = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Empleado datosEmpleado = new Empleado();

            if (dtEmpleado.Rows.Count > 0)
            {
                datosEmpleado.IdEmpleado = int.Parse(dtEmpleado.Rows[0]["IdEmpleado"].ToString());
                datosEmpleado.Nombre = dtEmpleado.Rows[0]["Nombre"].ToString();
                datosEmpleado.Direccion = dtEmpleado.Rows[0]["Direccion"].ToString();

                return datosEmpleado;
            }
            else
            {
                return null;
            }
        }

        public void insertarEmpleado(Empleado datosEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosEmpleado.Nombre));
            parametros.Add(new SqlParameter("@Direccion", datosEmpleado.Direccion));

            BaseHelper.ejecutarConsulta("sp_Empleado_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarEmpleado(int IdEmpleado)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", IdEmpleado));

            BaseHelper.ejecutarSentencia("sp_Empleado_Eliminar", CommandType.StoredProcedure, parametros);

        }

        public void actualizarEmpleado(Empleado datosEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", datosEmpleado.IdEmpleado));
            parametros.Add(new SqlParameter("@Nombre", datosEmpleado.Nombre));
            parametros.Add(new SqlParameter("@Direccion", datosEmpleado.Direccion));

            BaseHelper.ejecutarConsulta("sp_Empleado_Actualizar", CommandType.StoredProcedure, parametros);

        }
    }
}