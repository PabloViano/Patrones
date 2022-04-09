using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona
    {
        public string? NombreYApellido { get; set; }
        public short DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Ciudad { get; set; }
        public decimal IngresosNetosAnuales { get; set; }
    }
}
