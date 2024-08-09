using Laboratorio_2;

Operaciones misOperaciones=new Operaciones();

while(true)
{
    try
    {
        misOperaciones.MostrarMenuPrincipal();
        
    }
    catch(FormatException)
    {
        Console.WriteLine("Ha ingresado un caracter inválido, intentelo de nuevo");
        Console.ReadKey();
    }
}
