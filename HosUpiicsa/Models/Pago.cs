namespace HosUpiicsa.Models
{
    public class Pago
    {
        // Atributos
        public int id_pago { get; set; }
        public float total_pago { get; set; }
        public string metodo_pago { get; set; } = string.Empty;
        public bool edo_pago { get; set; }

        // ...
        public int getIdPago() => id_pago;
        public float getTotalPago() => total_pago;
        public void setTotalPago(float value) => total_pago = value;
        public string getMetodoPago() => metodo_pago;
        public void setMetodoPago(string value) => metodo_pago = value;
        public bool getEdoPago() => edo_pago;
        public void setEdoPago(bool value) => edo_pago = value;
    }
}