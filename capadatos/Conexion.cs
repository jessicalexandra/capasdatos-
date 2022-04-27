using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace capadatos
{
    public class Conexion
    {
        public SqlConnection conectar(string cnx)
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                oconectar.Open();
                return oconectar;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
