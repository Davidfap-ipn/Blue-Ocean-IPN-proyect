namespace HosUpiicsa.Models
{
    public class Usuario
    {
        // Atributos
        public int id_usuario { get; set; }
        public string ap_usuario { get; set; } = string.Empty;
        public string am_usuario { get; set; } = string.Empty;
        public string nom_usuario { get; set; } = string.Empty;
        public string email_usuario { get; set; } = string.Empty;
        public int tel_usuario { get; set; }

        // ...
        public int getIdUsuario() => id_usuario;
        public string getApUsuario() => ap_usuario;
        public void setApUsuario(string value) => ap_usuario = value;
        public string getAmUsuario() => am_usuario;
        public void setAmUsuario(string value) => am_usuario = value;
        public string getNomUsuario() => nom_usuario;
        public void setNomUsuario(string value) => nom_usuario = value;
        public string getEmail() => email_usuario;
        public void setEmail(string value) => email_usuario = value;
        public int getTelefono() => tel_usuario;
        public void setTelefono(int value) => tel_usuario = value;
    }
}