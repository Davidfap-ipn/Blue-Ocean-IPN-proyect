namespace HosUpiicsa.Models
{
    public class Habitacion
    {
        // Atributos
        public int id_habitacion { get; set; }
        public string nom_habitacion { get; set; } = string.Empty;
        public string tipoCama { get; set; } = string.Empty;
        public int no_camas { get; set; }
        public int capacidad { get; set; }
        public int precio { get; set; }
        public bool disponibilidad { get; set; }

        // Relación con Hotel
        public int id_hotel { get; set; }
        public Hotel hotel { get; set; } = null!;

        // ...
        public int getId() => id_habitacion;
        public string getNombre() => nom_habitacion;
        public void setNombre(string value) => nom_habitacion = value;
        public int getCamas() => no_camas;
        public void setCamas(int value) => no_camas = value;
        public int getPrecio() => precio;
        public void setPrecio(int value) => precio = value;
        public bool getDisponibilidad() => disponibilidad;
        public void setDisponibilidad(bool value) => disponibilidad = value;
    }
}