using System.ComponentModel.DataAnnotations.Schema;

namespace MiuMiu.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime FechaCliente { get; set; } = DateTime.Now;
        public List<Venta> Venta { get; set; } = new();
    }

    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public decimal Total { get; set; }

        public string Estado { get; set; } = "";
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public List<DetalleVenta> DetalleVenta { get; set; } = new();
    }

    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public Venta? Venta { get; set; }

        public int ProductoApiId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

    }
}