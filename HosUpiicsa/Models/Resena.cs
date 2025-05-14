using System;

namespace HosUpiicsa.Models
{
    public class Resena
    {
        // Atributos
        public int id_resena { get; set; }
        public DateTime fecha_resena { get; set; }
        public int calificacion { get; set; }
        public string desc_resena { get; set; } = string.Empty;

        // Relaciones
        public int id_usuario { get; set; }
        public Usuario usuario { get; set; } = null!;
        public int id_hotel { get; set; }
        public Hotel hotel { get; set; } = null!;

        // ...
        public int getIdResena() => id_resena;
        public DateTime getFecResena() => fecha_resena;
        public void setFecResena(DateTime value) => fecha_resena = value;
        public int getCalificacion() => calificacion;
        public void setCalificacion(int value) => calificacion = value;
        public string getDescResena() => desc_resena;
        public void setDescResena(string value) => desc_resena = value;
    }
}