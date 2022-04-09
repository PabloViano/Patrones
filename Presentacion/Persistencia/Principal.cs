using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Persistencia
{
    public sealed class Principal
    {
        public Logica.Empresa =  new Logica();
        private static Principal Instance = null;
        private Principal() { }
        public static Principal Instancia
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Principal();
                }
                return Instance;
            }
        }
        string jsonFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..Patrones\Presentacion\ArchivoTexto.txt");

    }
}