using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Aseguradora
    {
        public List<object> Aseguradoras;

        public int IdAseguradora { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }


        //Propiedad de Navegacion
        public ML.Usuario  Usuario { get; set; }
    }
}
