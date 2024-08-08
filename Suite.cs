using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Suite : Habitación
    {
        public int NumeroHabitaciones { get; set; }
        public bool Jacuzzi { get; set; }
        public Suite(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, int numeroHabitaciones, bool jacuzzi) : base(numeroHabitacion, precioNoche, disponibildiad, cliente)
        {
            NumeroHabitacion = numeroHabitaciones;
            Jacuzzi = jacuzzi;
        }

        public string MostrarJacuzzi(bool Jacuzzi)
        {
            if (Jacuzzi)
            {

                return "Cuenta con jacuzzi";
            }
            else
            {
                return "No uenta con jacuzzi";
            }
        }
        

    }
}
