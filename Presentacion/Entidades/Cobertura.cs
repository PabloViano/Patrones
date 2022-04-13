using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Cobertura
    {
        public string? Descripcion { get; set; }
        public string? Empresa { get; set; }
        public short CantidadPersonasMaxGF { get; set; }
        public decimal CostoBase { get; set; }
        public List<Enfermedad>? Enfermedades { get; set; }
        public decimal CostoFinal { get; set; }

        public abstract Cobertura CalcularCostoCobertura();

        public decimal SumarCostoEnfermedades()
        {
            decimal suma = 0;
            if (Enfermedades != null)
            {
                foreach (Enfermedad item in Enfermedades)
                {
                    suma += item.CostoAsociado;
                }
                return suma;
            }
            return suma;
        }
    }
}
