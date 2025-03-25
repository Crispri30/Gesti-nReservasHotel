using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónReservasHotel
{
    public enum TipoHabitacion
    {
        Estandar,
        VIP
    }
    public static class ReservaFactory
    {
        public static Reserva CrearReserva(TipoHabitacion tipo, string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, int tarifa)
        {
             switch (tipo)
             {
                case TipoHabitacion.Estandar:
                  return new HabitacionEstandar(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifa);

                case TipoHabitacion.VIP:
                  return new HabitacionVip(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifa);

                default:
                  throw new ArgumentException("Tipo de habitación no válido.");
                
            }
        }
    }
}