using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Atencion
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Enfermedad DatosEnfermedad { get; set; }
        public Persona DatosCliente { get; set; }
        public Atencion() { }
        public Atencion(int numero, DateTime fecha, Enfermedad datosEnfermedad, Persona datosCliente)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.DatosEnfermedad = datosEnfermedad;
            this.DatosCliente = datosCliente;
        }
    }
}
