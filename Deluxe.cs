using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Deluxe: Habitación
    {
        public string Desayuno { get; set; }
        public bool AccesoSpa { get; set; }
        public Deluxe(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, string desayuno, bool spa) : base(numeroHabitacion, precioNoche, disponibildiad, cliente)
        {
            Desayuno = desayuno;
            AccesoSpa = spa;
        }

        public string MostrarSpa(bool accesoSpa)
        {
            if (accesoSpa)
            {
                return "Cuenta con SPA";
            }
            else
            {
                return "No cuenta con SPA";
            }
        }
        

    }
}
