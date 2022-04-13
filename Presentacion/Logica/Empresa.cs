using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using System.Net.Mail;
using System.Net;

namespace Logica
{
    public sealed class Empresa
    {
        Persistencia.Principal principal = Persistencia.Principal.Instancia;
        private static Empresa? instancia = null;
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
        

        public bool BuscarYCalcularCoberturaPersona( int dni, Cobertura cobertura)
        {
            Persona? encontrado = Personas.Find(x => x.DNI == dni);
            if (encontrado != null)
            {
                if (encontrado.IngresosNetosAnuales >= cobertura.CostoFinal) { return true; }
            }
            return false;
        }
        public decimal CargarNuevaAtencion(int dni, int codigoEnfermedad)
        {
            CargarCliente();
            if (Enfermedades.Find(x => x.Codigo == codigoEnfermedad) != null && Personas.Find(x => x.DNI == dni) != null)
            {
                Atencion atencion = new Atencion(Atenciones.Count() + 1, DateTime.Now.Date, Enfermedades.Find(x => x.Codigo == codigoEnfermedad), Personas.Find(x => x.DNI == dni));
                Atenciones.Add(atencion);
                principal.GuardarListadoAtenciones(Atenciones);
                return Enfermedades.Find(x => x.Codigo == codigoEnfermedad).CostoAsociado;
            }
            return 0;
            
        }
        public int BuscarEnfermedad (string nombre)
        {
             CargarEnfermedades();
             Enfermedad? encontrada = Enfermedades.Find(x => x.Nombre == nombre);
             return encontrada.Codigo;
        }
        public bool EnviarEmail ()
        {
                MailAddress To = new MailAddress("pabloviano13@gmail.com");
                MailAddress From = new MailAddress("pruebaprogviano@gmail.com");
                MailMessage mail = new MailMessage(From, To);
                mail.Subject = "Nueva atención cargada";
                mail.Body = "Una atención nueva fue cargada con éxito! https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("pruebaprogviano@gmail.com", "calculadora2001");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return true;
        }

        //Codigo Prueba
        public void CargarEnfermedades()
        {
            Enfermedad enfermedad = new Enfermedad();
            enfermedad.Codigo = Enfermedades.Count + 1;
            enfermedad.Nombre = "Gripe";
            enfermedad.Tipo = TiposEnfermedades.Coronaria;
            enfermedad.CostoAsociado = 25000;
            Enfermedades.Add(enfermedad);
            principal.GuardarListadoEnfermedades(Enfermedades);
        }
        public void CargarCliente()
        {
            Persona persona = new Persona();
            persona.Ciudad = "Rafaela";
            persona.FechaNacimiento = DateTime.Now.Date;
            persona.IngresosNetosAnuales = 10000;
            persona.DNI = 123456;
            persona.NombreYApellido = "Pablo Viano";
            Personas.Add(persona);
            principal.GuardarListadoPersonas(Personas);
        }
    }
}