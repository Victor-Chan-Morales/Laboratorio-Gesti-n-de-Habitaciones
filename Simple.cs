using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Simple : Habitación
    {
        public int NumeroCamas { get; set; }
        public Simple(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, string tipoHabitacion, int numeroCamas) : base(numeroHabitacion, precioNoche, disponibildiad, cliente, tipoHabitacion)
        {
            NumeroCamas = numeroCamas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"EL número de cámas con el que cuenta la habitacíón es de: {NumeroCamas}");
        }


    }
}
