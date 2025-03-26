using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónReservasHotel
{
    public class HabitacionEstandar : Reserva
    {

        public HabitacionEstandar(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, int tarifaFija, double tarifaTotal)
            : base(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifaFija,  TipoHabitacion.Estandar, tarifaTotal) 
        {
            TarifaFija = tarifaFija;
        }
        
        public override double CalcularCostoTotal()
        {
            return TarifaTotal = TarifaFija * DuracionEstadia;
        }
    }
}
