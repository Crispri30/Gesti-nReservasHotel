using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónReservasHotel
{
    public abstract class Reserva
    {
        public string NombreCliente { get; set; }
        public int NumeroHabitacion { get; set; }
        public DateTime FechaReserva { get; set; }
        public int DuracionEstadia { get; set; }
        public int TarifaFija {  get; set; }
        public TipoHabitacion Tipo { get; set; }

        public double TarifaTotal { get; set; }

        protected Reserva(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, int tarifaFija, TipoHabitacion tipo, double tarifaTotal)
        {
            if (string.IsNullOrWhiteSpace(nombreCliente))
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }
            if (numeroHabitacion <= 0)
            {
                throw new ArgumentException("Indica un número mayor a 0");
            }

            if (duracionEstadia < 1)
            {
                throw new ArgumentException("La duración de la estadía debe ser mayor a 1 noche");
            }

            if (fechaReserva == DateTime.MinValue)
            {
                throw new ArgumentException("La fecha no puede estar vacía");
            }

            if (tarifaFija < 1 )
            {
                throw new ArgumentException("La tarifa no debe ser menor a 1");
            }

            NombreCliente = nombreCliente;
            NumeroHabitacion = numeroHabitacion;
            FechaReserva = fechaReserva;
            DuracionEstadia = duracionEstadia;
            TarifaFija = tarifaFija;
            Tipo = tipo;
            TarifaTotal = tarifaTotal;
        }

        public override string ToString()
        {
            return $"{NombreCliente} - Habitación {NumeroHabitacion} - {Tipo} - {FechaReserva.ToShortDateString()} - {DuracionEstadia} días - ${TarifaTotal}";
        }

        public abstract double CalcularCostoTotal();
    }
}
