using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool EliminarReserva(int numeroHabitacion)
        {
            //Busqueda de reserva por numero de habitacion
            var reserva = reservas.Find(r => r.NumeroHabitacion == numeroHabitacion);

            //si existe la elimina
            if (reserva != null) { 
                reservas.Remove(reserva);
                return true;
            }
            return false;
        }

        //Editar la reserva
        public bool EditarReserva(int numeroHabitacion, string nuevoNombre, DateTime nuevaFecha, int nuevaDuracion)
        {
            //Buscar la reserva por numero de habitacion
            var reserva = reservas.Find(r => r.NumeroHabitacion == numeroHabitacion);
            if (reserva != null)
            {
                reserva.NombreCliente = nuevoNombre;
                reserva.FechaReserva = nuevaFecha;
                reserva.DuracionEstadia = nuevaDuracion;

                return true;
            }
            return false;
            
        }

        //listar reservas
        public List<Reserva> ObtenerReservas()
        {
            return reservas;
        }

    }
}
