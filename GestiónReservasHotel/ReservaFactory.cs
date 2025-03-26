using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónReservasHotel
{
    public enum TipoHabitacion
    {
        Estandar,
        VIP
    }
    public static class ReservaFactory
    {
        public static Reserva CrearReserva(TipoHabitacion tipo, string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, int tarifa, double tarifaTotal)
        {
            switch (tipo)
             {
                case TipoHabitacion.Estandar:
                  return new HabitacionEstandar(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifa,tarifaTotal);

                case TipoHabitacion.VIP:
                  return new HabitacionVip(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifa, tarifaTotal);

                default:
                  throw new ArgumentException("Tipo de habitación no válido.");
                
            }
        }
    }
}