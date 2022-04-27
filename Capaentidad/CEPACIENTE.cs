using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capaentidad
{
  public  class CEPACIENTE
    {
        private string id_paciente;
        private string tip_documento;
        private string nombre_paciente;
        private string dir_paciente;
        private string tel_paciente;
        private string cel_paciente;
        private byte activo;

        public string Id_paciente { get => id_paciente; set => id_paciente = value; }
        public string Tip_documento { get => tip_documento; set => tip_documento = value; }
        public string Nombre_paciente { get => nombre_paciente; set => nombre_paciente = value; }
        public string Dir_paciente { get => dir_paciente; set => dir_paciente = value; }
        public string Tel_paciente { get => tel_paciente; set => tel_paciente = value; }
        public string Cel_paciente { get => cel_paciente; set => cel_paciente = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
