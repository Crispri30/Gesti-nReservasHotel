using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónReservasHotel
{
    public class HabitacionVip : Reserva
    {
        public int TarifaFija {  get; set; }

        public HabitacionVip (string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, int tarifaFija)
            : base (nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifaFija, TipoHabitacion.VIP) 
        
        {
            TarifaFija = tarifaFija;
        }

        public override double CalcularCostoTotal()
        {
            double total = TarifaFija * DuracionEstadia;
            if (DuracionEstadia > 5)
            {
                total *= 0.8; //aplicar 20% de descuento
            }

            return total;
        }
    }
}
