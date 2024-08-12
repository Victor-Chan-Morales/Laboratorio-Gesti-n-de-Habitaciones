using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Deluxe : Habitación
    {
        public bool Desayuno { get; set; }
        public bool AccesoSpa { get; set; }
        public Deluxe(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, string tipoHabitacion, bool desayuno, bool spa) : base(numeroHabitacion, precioNoche, disponibildiad, cliente, tipoHabitacion)
        {
            Desayuno = desayuno;
            AccesoSpa = spa;
        }

        public string MostrarSpa(bool spa)
        {
            if (AccesoSpa==true)
            {
                return "Cuenta con SPA";
            }
            else
            {
                return "No cuenta con SPA";
            }
        }
        public string MostrarDesayuno(bool desayuno)
        {
            if (Desayuno==true)
            {
                return "Incluye desayuno";
            }
            else
            {
                return "No incluye desayuno";
            }
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Servicios con los que cuenta la habitación:\n*SPA: {MostrarSpa(AccesoSpa)}\n*Desayuno: {MostrarDesayuno(Desayuno)}");
        }

    }
}
