namespace GestiónReservasHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.txtDuracionEstadia = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.lblTipoHabitacion = new System.Windows.Forms.Label();
            this.lblDuracionEstadia = new System.Windows.Forms.Label();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.lstReservas = new System.Windows.Forms.ListBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblTarifaFija = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormularioReservas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.BackColor = System.Drawing.Color.Linen;
            this.cmbTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(251, 281);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(309, 28);
            this.cmbTipoHabitacion.TabIndex = 0;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.Linen;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(251, 237);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(309, 26);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.BackColor = System.Drawing.Color.Linen;
            this.txtNumeroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(251, 369);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(309, 26);
            this.txtNumeroHabitacion.TabIndex = 2;
            // 
            // txtDuracionEstadia
            // 
            this.txtDuracionEstadia.BackColor = System.Drawing.Color.Linen;
            this.txtDuracionEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDuracionEstadia.Location = new System.Drawing.Point(251, 413);
            this.txtDuracionEstadia.Name = "txtDuracionEstadia";
            this.txtDuracionEstadia.Size = new System.Drawing.Size(309, 26);
            this.txtDuracionEstadia.TabIndex = 3;
            this.txtDuracionEstadia.TextChanged += new System.EventHandler(this.txtDuracionEstadia_TextChanged);
            // 
            // datetime
            // 
            this.datetime.CalendarMonthBackground = System.Drawing.Color.Linen;
            this.datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(251, 323);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(309, 26);
            this.datetime.TabIndex = 4;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.PeachPuff;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(26, 240);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(134, 20);
            this.lblNombreCliente.TabIndex = 5;
            this.lblNombreCliente.Text = "Nombre cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de habitación:";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.BackColor = System.Drawing.Color.PeachPuff;
            this.lblFechaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.Location = new System.Drawing.Point(26, 329);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(153, 20);
            this.lblFechaReserva.TabIndex = 7;
            this.lblFechaReserva.Text = "Fecha de reserva:";
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoHabitacion.Location = new System.Drawing.Point(26, 284);
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(161, 20);
            this.lblTipoHabitacion.TabIndex = 8;
            this.lblTipoHabitacion.Text = "Tipo de habitación:";
            // 
            // lblDuracionEstadia
            // 
            this.lblDuracionEstadia.AutoSize = true;
            this.lblDuracionEstadia.BackColor = System.Drawing.Color.PeachPuff;
            this.lblDuracionEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDuracionEstadia.Location = new System.Drawing.Point(26, 416);
            this.lblDuracionEstadia.Name = "lblDuracionEstadia";
            this.lblDuracionEstadia.Size = new System.Drawing.Size(150, 20);
            this.lblDuracionEstadia.TabIndex = 9;
            this.lblDuracionEstadia.Text = "Duracion estadía:";
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.Color.BurlyWood;
            this.bttAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bttAgregar.Location = new System.Drawing.Point(30, 523);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(137, 69);
            this.bttAgregar.TabIndex = 10;
            this.bttAgregar.Text = "Agregar Reserva";
            this.bttAgregar.UseVisualStyleBackColor = false;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.BackColor = System.Drawing.Color.BurlyWood;
            this.bttEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bttEditar.Location = new System.Drawing.Point(231, 523);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(137, 69);
            this.bttEditar.TabIndex = 11;
            this.bttEditar.Text = "Editar Reserva";
            this.bttEditar.UseVisualStyleBackColor = false;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.BackColor = System.Drawing.Color.BurlyWood;
            this.bttEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bttEliminar.Location = new System.Drawing.Point(423, 523);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(137, 69);
            this.bttEliminar.TabIndex = 13;
            this.bttEliminar.Text = "Eliminar Reserva";
            this.bttEliminar.UseVisualStyleBackColor = false;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // lstReservas
            // 
            this.lstReservas.BackColor = System.Drawing.Color.Linen;
            this.lstReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReservas.FormattingEnabled = true;
            this.lstReservas.Location = new System.Drawing.Point(588, 240);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.Size = new System.Drawing.Size(628, 342);
            this.lstReservas.TabIndex = 14;
            this.lstReservas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtTarifa
            // 
            this.txtTarifa.BackColor = System.Drawing.Color.Linen;
            this.txtTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTarifa.Location = new System.Drawing.Point(251, 456);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(309, 26);
            this.txtTarifa.TabIndex = 15;
            // 
            // lblTarifaFija
            // 
            this.lblTarifaFija.AutoSize = true;
            this.lblTarifaFija.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTarifaFija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarifaFija.Location = new System.Drawing.Point(26, 459);
            this.lblTarifaFija.Name = "lblTarifaFija";
            this.lblTarifaFija.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTarifaFija.Size = new System.Drawing.Size(89, 20);
            this.lblTarifaFija.TabIndex = 16;
            this.lblTarifaFija.Text = "Tarifa fija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "CC HOTEL";
            // 
            // lblFormularioReservas
            // 
            this.lblFormularioReservas.AutoSize = true;
            this.lblFormularioReservas.BackColor = System.Drawing.Color.PeachPuff;
            this.lblFormularioReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioReservas.Location = new System.Drawing.Point(434, 146);
            this.lblFormularioReservas.Name = "lblFormularioReservas";
            this.lblFormularioReservas.Size = new System.Drawing.Size(314, 31);
            this.lblFormularioReservas.TabIndex = 18;
            this.lblFormularioReservas.Text = "Formulario de reservas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestiónReservasHotel.Properties.Resources.lgo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(39, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 141);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = global::GestiónReservasHotel.Properties.Resources.fondo_hotel__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormularioReservas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTarifaFija);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.lstReservas);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.lblDuracionEstadia);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.txtDuracionEstadia);
            this.Controls.Add(this.txtNumeroHabitacion);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.TextBox txtDuracionEstadia;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.Label lblTipoHabitacion;
        private System.Windows.Forms.Label lblDuracionEstadia;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.ListBox lstReservas;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblTarifaFija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFormularioReservas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

