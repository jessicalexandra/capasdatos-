using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capaentidad;
using System.Data;
using capadatos;

namespace capaNegocio
{
    public class CNCITA
    {
        CDCITA odacita = new CDCITA();
        public bool guardar_cita(CECITA oencita)
        {
            return odacita.guardar_cita(oencita);
        }
    
        public bool anular_cita(CECITA oencita)
        {
            return odacita.anula_cita( oencita);
        }

        public DataSet consultar_cita(CECITA oencita)
        {
            return odacita.consultar_cita(oencita);
        }

    }
}
