using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CoberturaMaxima : Cobertura
    {
        //Para la cobertura máxima el costo se calcula sumando los costos de todas las enfermedades asociadas.
        public override Cobertura CalcularCostoCobertura()
        {
            this.CostoFinal = SumarCostoEnfermedades();
            return this;
        }
    }
}
