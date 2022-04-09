using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Empresa
    {
        private static Empresa instancia = null;
        public static Empresa Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Empresa();
                }
                return instancia;
            }
        }
        List<Persona> Personas = new List<Persona>();
        List<Cobertura> Coberturas = new List<Cobertura>();
        List<Atencion> Atenciones = new List<Atencion>();
        List<Enfermedad> Enfermedades = new List<Enfermedad>();
        private Empresa() { }
        

        public bool BuscarYCalcularCoberturaPersona( short dni, Cobertura cobertura)
        {
            Persona encontrado = Personas.Find(x => x.DNI == dni);
            if (encontrado != null)
            {
                if (encontrado.IngresosNetosAnuales >= cobertura.CostoFinal) { return true; }
            }
            return false;
        }
        public decimal CargarNuevaAtencion(short dni, short codigoEnfermedad)
        {
            if (Enfermedades.Find(x => x.Codigo == codigoEnfermedad) != null && Personas.Find(x => x.DNI == dni) != null)
            {
                Atencion atencion = new Atencion(Atenciones.Count() + 1, DateTime.Now.Date, Enfermedades.Find(x => x.Codigo == codigoEnfermedad), Personas.Find(x => x.DNI == dni));
                Atenciones.Add(atencion);
                return Enfermedades.Find(x => x.Codigo == codigoEnfermedad).CostoAsociado;
            }
            return 0;
            
        }
    }
}