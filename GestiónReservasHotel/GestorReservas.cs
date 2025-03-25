using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónReservasHotel
{
    //patron singleton y Crud de reservas
    public class GestorReservas
    {
        //instancia única
        private static GestorReservas _instancia;

        //metodo obtener instancia para acceder a la única instancia creada
        public static GestorReservas ObtenerInstancia()
        {
            if( _instancia == null)
            {
                _instancia = new GestorReservas();
            }
            return _instancia;
        }

        //lista de reserva
        private List<Reserva> reservas;

        //Constructor de la lista
        private GestorReservas()
        {
            reservas = new List<Reserva>();
        }
        

        public void AgregarReserva(Reserva nuevaReserva)
        {
            //verificar si hay una reserva con el mismo numero de habitacion en la misma fecha
            bool existeReserva = reservas.Exists(r =>
                r.NumeroHabitacion == nuevaReserva.NumeroHabitacion &&
                r.FechaReserva.Date == nuevaReserva.FechaReserva.Date);
            if (existeReserva)
            {
                throw new InvalidOperationException("Ya existe una reserva para la fecha y habitacion seleccionada");
            }

            reservas.Add(nuevaReserva);
            
            
        }


        public bool EliminarReserva(int numeroHabitacion, DateTime fechaReserva, string nombreCliente)
        {
            //Busqueda de reserva por numero de habitacion
            var reserva = reservas.Find(r => r.NumeroHabitacion == numeroHabitacion &&
            r.FechaReserva == fechaReserva && r.NombreCliente == nombreCliente);

            //si existe la elimina
            if (reserva != null) { 
                reservas.Remove(reserva);
                return true;
            }
            else
            {
                MessageBox.Show("Reserva no encontrada");
            }
                return false;
        }

        //Editar la reserva
        public void EditarReserva(int numeroHabitacion, string nombreCliente, DateTime nuevaFecha, int nuevaDuracion, int nuevaTarifa, TipoHabitacion tipo)
        {
            //Buscar la reserva por numero de habitacion
            var reserva = reservas.Find(r => r.NumeroHabitacion == numeroHabitacion &&
            r.NombreCliente == nombreCliente);
            if (reserva != null)
            {
                reserva.FechaReserva = nuevaFecha;
                reserva.DuracionEstadia = nuevaDuracion;
                reserva.TarifaFija = nuevaTarifa;
                reserva.Tipo = tipo;
            }
            else
            {
                MessageBox.Show("Reserva no encontrada.");
            }
        }

        //listar reservas
        public List<Reserva> ObtenerReservas()
        {
            return reservas;
        }
    }
}
