using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class IdentificacionEntity
    {
        public int? IdCedula { get; set; }

        public int? IdTipoIdentificacion { get; set; }
        public string Pasaporte { get; set; }
        public string CedulaJuridica { get; set; }
        public string Descripcion { get; set; }
        
    }
}
