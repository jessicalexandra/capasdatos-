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
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
