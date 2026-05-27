namespace MiuMiu.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string telefono { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public DateTime fechaRegistro { get; set; } = DateTime.Now;
    }

    public class Venta
    {
        public int Id { get; set; }
        public int clienteId { get; set; } 
        public DateTime fecha { get; set; } = DateTime.Now;
        public decimal total { get; set; }
        public string estado { get; set; } = string.Empty;
    }

    public class Detalle
    {
        public int Id { get; set; }
        public int ventaId { get; set; } 

        // Aquí guardas el "Id" que viene de la clase ProductoTodos de la API
        public int productoApiId { get; set; }

        public int cantidad { get; set; }
        public decimal precio { get; set; }
    }
}
