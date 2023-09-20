using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Dependiente
    {
        public List<object> Dependientes;

        public int idDependiente { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string EstadoCivil { get; set; }

        public string Genero { get; set; }

        public string Telefono { get; set; }

        public string RFC { get; set; }
        //prop navegacion 

    }
}
