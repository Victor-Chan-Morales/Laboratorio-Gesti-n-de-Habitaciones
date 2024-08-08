using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Habitación
    {
        public int NumeroHabitacion { get; set; }
        public double PrecioNoche { get; set; }
        public bool Disponibildiad { get; set; }
        public string Cliente { get; set; }

        public Habitación(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente)
        {
            NumeroHabitacion = numeroHabitacion;
            PrecioNoche = precioNoche;
            Disponibildiad = disponibildiad;
            Cliente = cliente;
        }
        public string MostrarDisponibildiad(bool disponibilidad)
        {
            if (Disponibildiad==true)
            {
                 return "Disponible";
            }
            else
            {
                return "No Disponible"; 
            }
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Número de habitación: {NumeroHabitacion} -- Precio por noche: Q{PrecioNoche} -- Disponibilidad: {MostrarDisponibildiad(Disponibildiad)} ");
        }
        public bool CambiarDisponibilidad(bool disponibilidad)
        {
            if (Disponibildiad==true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string AsignarCliente()
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente=Console.ReadLine().ToUpper();
            return nombreCliente;
        }
        public void LiberarHabitacion()
        {
            CambiarDisponibilidad(Disponibildiad);
            Cliente = "";
        }

    }
}
