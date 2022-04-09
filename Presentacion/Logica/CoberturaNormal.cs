﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CoberturaNormal : Cobertura
    {
        //ara la cobertura normal, el costo se calcula sumando el costo base + el promedio de costos de todas las enfermedades asociadas.
        public override Cobertura CalcularCostoCobertura()
        {
            this.CostoFinal = (this.CostoBase) + (SumarCostoEnfermedades() / this.Enfermedades.Count() + 1);
            return this;
        }
    }
}
