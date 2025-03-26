using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónReservasHotel
{
    public class HabitacionVip : Reserva
    {
        public HabitacionVip (string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, int tarifaFija, double tarifaTotal)
            : base (nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifaFija, TipoHabitacion.VIP, tarifaTotal) 
        
        {
            TarifaFija = tarifaFija;
        }

        public override double CalcularCostoTotal()
        {
            
            if (DuracionEstadia > 5)
            {
                 //aplicar 20% de descuento
                TarifaTotal = (TarifaFija * DuracionEstadia) * 0.8;
            }

            return TarifaTotal;
        }
    }
}
