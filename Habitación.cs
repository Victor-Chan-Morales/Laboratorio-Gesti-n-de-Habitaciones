﻿using System;
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
        public string TipoHabitacion { get; set; }

        public Habitación(int numeroHabitacion, double precioNoche, bool disponibildiad, string cliente, string tipoHabitacion)
        {
            NumeroHabitacion = numeroHabitacion;
            PrecioNoche = precioNoche;
            Disponibildiad = disponibildiad;
            Cliente = cliente;
            TipoHabitacion = tipoHabitacion;
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
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"*Número de habitación: {NumeroHabitacion} --- Tipo de habitación: {TipoHabitacion} -- Precio por noche: Q{PrecioNoche} -- Disponibilidad: {MostrarDisponibildiad(Disponibildiad)} -- Cliente: {Cliente}");
        }
        
    }
}
