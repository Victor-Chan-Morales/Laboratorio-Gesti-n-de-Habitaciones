using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Suite : Habitación
    {
        public int CantidadHabitaciones { get; set; }
        public bool Jacuzzi { get; set; }
        public Suite(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, string tipoHabitacion, int numeroHabitaciones, bool jacuzzi) : base(numeroHabitacion, precioNoche, disponibildiad, cliente, tipoHabitacion)
        {
            CantidadHabitaciones = numeroHabitaciones;
            Jacuzzi = jacuzzi;
        }

        public string MostrarJacuzzi(bool jacuzzi)
        {
            if (Jacuzzi == true)
            {

                return "Cuenta con jacuzzi";
            }
            else
            {
                return "No uenta con jacuzzi";
            }
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"La Souite cuenta con {CantidadHabitaciones} habitaciones. \n¿Cuenta con jacuzzi?: {MostrarJacuzzi(Jacuzzi)}");
        }


    }
}
