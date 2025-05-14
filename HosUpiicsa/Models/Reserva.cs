using System;
using System.ComponentModel.DataAnnotations;

namespace HosUpiicsa.Models
{
    public class Reserva
    {
        // Atributos
        public int id_reserva { get; set; }
        
        [Display(Name = "Fecha de Entrada")]
        [Required(ErrorMessage = "La fecha de entrada es obligatoria")]
        public DateTime fecha_entrada { get; set; }
        
        [Display(Name = "Fecha de Salida")]
        [Required(ErrorMessage = "La fecha de salida es obligatoria")]
        public DateTime fecha_salida { get; set; }
        
        [Display(Name = "Hora de Entrada")]
        public TimeSpan hora_entrada { get; set; }
        
        [Display(Name = "Hora de Salida")]
        public TimeSpan hora_salida { get; set; }
        
        [Display(Name = "Estado de la Reserva")]
        public bool edo_reserva { get; set; } = true;
        
        [Display(Name = "Fecha de Reservación")]
        public DateTime fecha_reserva { get; set; } = DateTime.Now;

        // Relaciones
        [Required(ErrorMessage = "El usuario es requerido")]
        public int id_usuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        
        [Required(ErrorMessage = "La habitación es requerida")]
        public int id_habitacion { get; set; }
        public Habitacion habitacion { get; set; } = null!;
        
        [Required(ErrorMessage = "El pago es requerido")]
        public int id_pago { get; set; }
        public Pago pago { get; set; } = null!;

        // ....
        public int getIdReserva() => id_reserva;
        public DateTime getFechaEntrada() => fecha_entrada;
        public void setFechaEntrada(DateTime value) => fecha_entrada = value;
        public DateTime getFechaSalida() => fecha_salida;
        public void setFechaSalida(DateTime value) => fecha_salida = value;
        public TimeSpan getHoraEntrada() => hora_entrada;
        public void setHoraEntrada(TimeSpan value) => hora_entrada = value;
        public TimeSpan getHoraSalida() => hora_salida;
        public void setHoraSalida(TimeSpan value) => hora_salida = value;
        public bool getEdoReserva() => edo_reserva;
        public void setEdoReserva(bool value) => edo_reserva = value;
    }
}