using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Doble : Habitación
    {
        public bool VistaMar { get; set; }
        public Doble(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, bool vistaMar) : base(numeroHabitacion, precioNoche, disponibildiad, cliente)
        {
            VistaMar = vistaMar;
        }

        

    }
}
