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
        public Simple(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, int numeroCamas) : base(numeroHabitacion, precioNoche, disponibildiad, cliente)
        {
            NumeroCamas = numeroCamas;
        }

        

    }
}
