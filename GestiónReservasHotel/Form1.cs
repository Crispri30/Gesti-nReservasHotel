using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónReservasHotel
{
    public partial class Form1 : Form
    {
        private GestorReservas gestor;
        public Form1()
        {
            InitializeComponent();
            gestor = GestorReservas.ObtenerInstancia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar las opciones al ComboBox

            cmbTipoHabitacion.DataSource = Enum.GetValues(typeof(TipoHabitacion));
            
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCliente = txtNombreCliente.Text;
                DateTime fechaReserva = DateTime.Parse(datetime.Text);
                int numeroHabitacion = int.Parse(txtNumeroHabitacion.Text);
                int duracionEstadia = int.Parse(txtDuracionEstadia.Text);
                int tarifaFija = int.Parse(txtTarifa.Text);

                
                if (!Enum.TryParse(cmbTipoHabitacion.SelectedItem.ToString(), out TipoHabitacion tipo))
                {
                    MessageBox.Show("Error: Tipo de habitación no válido.");
                    return;
                }

                //Creacion nueva reserva
                Reserva nuevaReserva = ReservaFactory.CrearReserva(tipo, nombreCliente,numeroHabitacion,fechaReserva,duracionEstadia,tarifaFija);
                gestor.AgregarReserva(nuevaReserva);
                lstReservas.Items.Add(nuevaReserva);

                cmbTipoHabitacion.SelectedIndex = 0;
                txtDuracionEstadia.Clear();
                txtNombreCliente.Clear();
                txtNumeroHabitacion.Clear();
                txtTarifa.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            try
            {

                string nombreCliente = txtNombreCliente.Text;
                DateTime fechaReserva = DateTime.Parse(datetime.Text);
                int numeroHabitacion = int.Parse(txtNumeroHabitacion.Text);
                int duracionEstadia = int.Parse(txtDuracionEstadia.Text);
                int tarifaFija = int.Parse(txtTarifa.Text);

                if (!Enum.TryParse(cmbTipoHabitacion.SelectedItem.ToString(), out TipoHabitacion tipo))
                {
                    MessageBox.Show("Error: Tipo de habitación no válido.");
                    return;
                }

                gestor.EditarReserva(numeroHabitacion, nombreCliente, fechaReserva, duracionEstadia, tarifaFija, tipo);

                lstReservas.Items.Clear();
                foreach (var reserva in gestor.ObtenerReservas())
                {
                    lstReservas.Items.Add(reserva);
                }

                txtDuracionEstadia.Clear();
                txtNombreCliente.Clear();
                txtNumeroHabitacion.Clear();
                txtTarifa.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCliente = txtNombreCliente.Text;
                DateTime fechaReserva = DateTime.Parse(datetime.Text);
                int numeroHabitacion = int.Parse(txtNumeroHabitacion.Text);
                int duracionEstadia = int.Parse(txtDuracionEstadia.Text);

                gestor.EliminarReserva(numeroHabitacion, fechaReserva, nombreCliente);

                lstReservas.Items.Clear();
                foreach (var reserva in gestor.ObtenerReservas())
                {
                    lstReservas.Items.Add(reserva);
                }

                txtDuracionEstadia.Clear();
                txtNombreCliente.Clear();
                txtNumeroHabitacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDuracionEstadia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
