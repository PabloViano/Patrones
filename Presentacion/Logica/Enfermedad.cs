using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Enfermedad
    {
        public short Codigo { get; set; }
        public TiposEnfermedades Tipo { get; set; }
        public string Nombre { get; set; }
        public decimal CostoAsociado { get; set; }
    }
    public enum TiposEnfermedades { CORONARIA, MENTAL, ETC }
}
