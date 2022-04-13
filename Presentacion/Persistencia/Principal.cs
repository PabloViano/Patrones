using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public sealed class Principal
    {
        private static Principal? Instance = null;
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
        string pathPersonas = @"A:\User\Pablo\Universidad\Programacion ll\Patrones\Patrones\Presentacion\Personas.txt";
        List<Persona>? Personas = new List<Persona>();
        string pathCoberturas = @"A:\User\Pablo\Universidad\Programacion ll\Patrones\Patrones\Presentacion\Coberturas.txt";
        List<Cobertura>? Coberturas = new List<Cobertura>();
        string pathEnfermedades = @"A:\User\Pablo\Universidad\Programacion ll\Patrones\Patrones\Presentacion\Enfermedades.txt";
        List<Enfermedad>? Enfermedades = new List<Enfermedad>();
        string pathAtenciones = @"A:\User\Pablo\Universidad\Programacion ll\Patrones\Patrones\Presentacion\Atenciones.txt";
        List<Atencion>? Atenciones = new List<Atencion>();
        public List<Persona>? LeerPersonas()
        {
            if (File.Exists(pathPersonas))
            {
                using (StreamReader reader = new StreamReader(pathPersonas))
                {
                    string persona = reader.ReadToEnd();
                    if (persona != "")
                    {
                        Personas = JsonConvert.DeserializeObject<List<Persona>>(persona);
                    }
                }
            }
            return Personas;
        }
        public List<Cobertura>? LeerCoberturas()
        {
            if (File.Exists(pathCoberturas))
            {
                using (StreamReader reader = new StreamReader(pathCoberturas))
                {
                    string cobertura = reader.ReadToEnd();
                    if (cobertura != "" && cobertura != null)
                    {
                        Coberturas = JsonConvert.DeserializeObject<List<Cobertura>>(cobertura);
                    }
                }
            }
            return Coberturas;
        }
        public List<Enfermedad>? LeerEnfermedades()
        {
            if (File.Exists(pathEnfermedades))
            {
                using (StreamReader reader = new StreamReader(pathEnfermedades))
                {
                    string enfermedad = reader.ReadToEnd();
                    if (enfermedad != "" && enfermedad != null)
                    {
                        Enfermedades = JsonConvert.DeserializeObject<List<Enfermedad>>(enfermedad);
                    }
                }
            }
            return Enfermedades;
        }
        public List<Atencion>? LeerAtenciones()
        {
            if (File.Exists(pathAtenciones))
            {
                using (StreamReader reader = new StreamReader(pathAtenciones))
                {
                    string atencion = reader.ReadToEnd();
                    if (atencion != "" && atencion != null)
                    {
                        Atenciones = JsonConvert.DeserializeObject<List<Atencion>>(atencion);
                    }
                }
            }
            return Atenciones;
        }
        public void GuardarListadoPersonas(List<Persona> PersonasListado)
        {
            if (!File.Exists(pathPersonas))
            {
                File.Create(pathPersonas);
                using (StreamWriter writer = new StreamWriter(pathPersonas, false))
                {
                    string personaJson = JsonConvert.SerializeObject(PersonasListado);
                    writer.Write(personaJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathPersonas, false))
                {
                    string personaJson = JsonConvert.SerializeObject(PersonasListado);
                    writer.Write(personaJson);
                }
            }
        }
        public void GuardarListadoCoberturas(List<Cobertura> CoberturaListado)
        {
            if (!File.Exists(pathCoberturas))
            {
                File.Create(pathCoberturas);
                using (StreamWriter writer = new StreamWriter(pathCoberturas, false))
                {
                    string coberturaJson = JsonConvert.SerializeObject(CoberturaListado);
                    writer.Write(coberturaJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathCoberturas, false))
                {
                    string coberturaJson = JsonConvert.SerializeObject(CoberturaListado);
                    writer.Write(coberturaJson);
                }
            }
        }
        public void GuardarListadoEnfermedades(List<Enfermedad> EnfermedadesListado)
        {
            if (!File.Exists(pathEnfermedades))
            {
                File.Create(pathEnfermedades);
                using (StreamWriter writer = new StreamWriter(pathEnfermedades, false))
                {
                    string enfermedadJson = JsonConvert.SerializeObject(EnfermedadesListado);
                    writer.Write(enfermedadJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathEnfermedades, false))
                {
                    string enfermedadJson = JsonConvert.SerializeObject(EnfermedadesListado);
                    writer.Write(enfermedadJson);
                }
            }
        }
        public void GuardarListadoAtenciones(List<Atencion> AtencionesListado)
        {
            if (!File.Exists(pathAtenciones))
            {
                File.Create(pathAtenciones);
                using (StreamWriter writer = new StreamWriter(pathAtenciones, false))
                {
                    string atencionJson = JsonConvert.SerializeObject(AtencionesListado);
                    writer.Write(atencionJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathAtenciones, false))
                {
                    string atencionJson = JsonConvert.SerializeObject(AtencionesListado);
                    writer.Write(atencionJson);
                }
            }
        }

    }
}