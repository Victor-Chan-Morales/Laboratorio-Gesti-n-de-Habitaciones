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
        public Doble(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, string tipoHabitacion, bool vistaMar) : base(numeroHabitacion, precioNoche, disponibildiad, cliente, tipoHabitacion)
        {
            VistaMar = vistaMar;
        }

        public string MostrarVista(bool vistaMar)
        {
            if (vistaMar)
            {
                return "Cuenta con vista al mar";
            }
            else
            {
                return "No cuenta con vista al mar";
            }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Vista al mar: {MostrarVista(VistaMar)}");
        }
    }
}
