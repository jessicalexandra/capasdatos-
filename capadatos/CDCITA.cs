using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capaentidad;
using System.Data;

namespace capadatos
{
    public class CDCITA
    {
        Conexion objconex = new Conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool guardar_cita(CECITA ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = objconex.conectar("BDhospital");
                ocmd.CommandText = "agregar_cita";
                ocmd.Parameters.AddWithValue("@cod_cita", ocitas.Cod_cita);
                ocmd.Parameters.AddWithValue("@fecha", ocitas.Fecha);
                ocmd.Parameters.AddWithValue("@hora", ocitas.Hora);
                ocmd.Parameters.AddWithValue("@id_paciente", ocitas.Id_paciente);
                ocmd.Parameters.AddWithValue("@id_medico", ocitas.Id_medico);
                ocmd.Parameters.AddWithValue("@valor", ocitas.Valor);
                ocmd.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@Nom_acompañante", ocitas.Nom_acompañante1);
                ocmd.Parameters.Add("@activo", ocitas.Activo);

                ocmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool anula_cita(CECITA ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = objconex.conectar("BDhospital");
                ocmd.CommandText = "modificar_cita";
                ocmd.Parameters.AddWithValue("@cod_cita", ocitas.Cod_cita);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultar_cita(CECITA ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = objconex.conectar("BDhospital");
                ocmd.CommandText = "consultar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }

    

}
