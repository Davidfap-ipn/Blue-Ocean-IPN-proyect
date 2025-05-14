namespace HosUpiicsa.Models
{
    public class Hotel
    {
        // Atributos
        public int id_hotel { get; set; }
        public string tipo_hotel { get; set; } = string.Empty;
        public string calle_hotel { get; set; } = string.Empty;
        public string alc_hotel { get; set; } = string.Empty;
        public int cp_hotel { get; set; }
        public string col_hotel { get; set; } = string.Empty;
        public int tel_hotel { get; set; }
        public bool disponibilidad { get; set; } = true;

        // ...
        public string getNomHotel() => col_hotel + " Resort";
        public void setNomHotel(string nombre) => col_hotel = nombre;
        public string getUbicacion() => $"{calle_hotel}, {col_hotel}";
        public void setUbicacion(string calle, string colonia) 
        { 
            calle_hotel = calle; 
            col_hotel = colonia; 
        }
        public int getTelefono() => tel_hotel;
        public void setTelefono(int telefono) => tel_hotel = telefono;
    }
}