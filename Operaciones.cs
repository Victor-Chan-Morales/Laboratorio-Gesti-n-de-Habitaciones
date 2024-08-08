using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Operaciones
    {
        public static List<Habitación> ListaHabitaciones = new List<Habitación>();

        public void MostrarMenuTipoHabitaciones()
        {
            Console.WriteLine("TIPO DE HABITACIONES DISPONIBLES ");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Deluxe");
            Console.WriteLine("Seleccione una opción: ");
        }
        public void MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("1. Agregar habitación");
            Console.WriteLine("2. Eliminar habitación");
            Console.WriteLine("3. Mostrar habitaciones disponibles");
            Console.WriteLine("4. Reservar/ocupar habitación");
            Console.WriteLine("5. Liberar habitación");
            Console.WriteLine("0. Salir del programa");
            Console.Write("Seleccione una opción: ");
            int menuPrincipal=int.Parse(Console.ReadLine());
            switch(menuPrincipal)
            {
                case 1:
                    AgregarHabitacion();
                    break;
                case 2:
                    EliminarHabitacion();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Esta opción no está disponible, ingrese una opción válida...");
                    Console.ReadKey();
                    break;
            }
        }
        public void AgregarHabitacion()
        {
            Console.Clear();
            MostrarMenuTipoHabitaciones();
            int tipoHabitacion=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de habitación: ");
            int numeroHabitacion=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio por noche de hospedaje: Q");
            double precioNoche=double.Parse(Console.ReadLine());
            switch(tipoHabitacion)
            {
                case 1:
                    Console.Write("Ingrese la cantidad de camas dentro de la habitación: ");
                    int cantidadCamas=int.Parse(Console.ReadLine());
                    ListaHabitaciones.Add(new Simple(numeroHabitacion, precioNoche, true, "", cantidadCamas));
                    Console.WriteLine("Habitación agregada..."); Console.ReadKey();
                    break;
                case 2:
                    while (true)
                    {
                        Console.Write("¿La habitación doble tiene vista al mar? s/n: ");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta =="s")
                        {
                            ListaHabitaciones.Add(new Doble(numeroHabitacion,precioNoche,true,"",true));
                            Console.WriteLine("Habitación agregada..."); Console.ReadKey();
                            break;
                        }
                        else if (respuesta =="n")
                        {
                            ListaHabitaciones.Add(new Doble(numeroHabitacion, precioNoche, true, "", false));
                            Console.WriteLine("Habitación agregada..."); Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar s o n");
                        }
                    }
                    break;
                case 3:
                    Console.Write("Ingrese el número de habitaciones con las cuales cuenta la Suite: ");
                    int cantidadHabitaciones=int.Parse(Console.ReadLine());
                    while(true)
                    {
                        Console.Write("¿La suite cuenta con Jacuzzi? s/n: ");
                        string cuentaJacuzzi=Console.ReadLine().ToLower();
                        if (cuentaJacuzzi =="s")
                        {
                            ListaHabitaciones.Add(new Suite(numeroHabitacion, precioNoche, true, "", cantidadHabitaciones, true));
                            Console.WriteLine("Habitación agregada..."); Console.ReadKey();
                            break;
                        }
                        else if (cuentaJacuzzi=="n")
                        {
                            ListaHabitaciones.Add(new Suite(numeroHabitacion, precioNoche, true, "", cantidadHabitaciones, false));
                            Console.WriteLine("Habitación agregada..."); Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar s o n...");
                            Console.ReadKey();
                        }
                    }
                break;                
            }
        }
        public void EliminarHabitacion()
        {
            Console.Clear();
            Console.Write("Ingrese el número de la habitación a eliminar: ");
            int eliminarHabitacion=int.Parse(Console.ReadLine());
            Habitación eliminar=ListaHabitaciones.Find(c=>c.NumeroHabitacion==eliminarHabitacion);
            if (eliminar!=null)
            {
                ListaHabitaciones.Remove(eliminar);
                Console.WriteLine($"Se ha eliminado exitosamente los datos de la habitación: {eliminarHabitacion}");
            }
            else
            {
                Console.WriteLine("No se encuentra registrada esta habitación...");
            }
            Console.ReadKey();
        }
    }
}
