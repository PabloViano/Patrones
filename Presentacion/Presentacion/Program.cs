//Cargar Atenciones
using Logica;


Console.WriteLine("(Escriba en consola el numero de la acción que desea realizar)");
Console.WriteLine("Menu:");
Console.WriteLine("1-Cargar Nueva Atencion");
string Accion = Console.ReadLine();
while (Accion == null || Accion != "1" || Accion == "")
{
    Console.WriteLine("Error: Valor incorrecto");
    Console.WriteLine("1-Cargar Nueva Atencion");
    Accion = Console.ReadLine();
}
Console.Clear();
Console.Write("Cargar nueva atencion: ");
Console.WriteLine("Ingrese su nombre y apellido: ");
string? NombreyApellido = Console.ReadLine();
while (NombreyApellido == null || NombreyApellido == "")
{ Console.WriteLine("Error: Valor incorrecto"); }
Console.WriteLine("Ingrese su DNI: ");
string dni = Console.ReadLine();
Console.WriteLine("Ingrese su endermedad (Coronaria, Mental, Etc): ");
string Enfermedad = Console.ReadLine();
Empresa newEmpresa = Empresa.Instancia;
newEmpresa.CargarNuevaAtencion(int.Parse(dni), newEmpresa.BuscarEnfermedad(Enfermedad));
newEmpresa.EnviarEmail();



