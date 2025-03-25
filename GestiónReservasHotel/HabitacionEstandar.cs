using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónReservasHotel
{
    public class HabitacionEstandar : Reserva
    {
        public int TarifaFija {  get; set; }

        public HabitacionEstandar(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, int tarifaFija)
            : base(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia, tarifaFija,  TipoHabitacion.Estandar) 
        {
            TarifaFija = tarifaFija;
        }
        
        public override double CalcularCostoTotal()
        {
            return TarifaFija * DuracionEstadia;
        }
    }
}
