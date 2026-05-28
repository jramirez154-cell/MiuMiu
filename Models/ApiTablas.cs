namespace MiuMiu.Models
{
    public class CategoriaModelo
    {
        public int Id { get; set; }
        public string nombre { get; set; } = "";
        public string descripcion { get; set; } = "";
    }

    public class ProductoModelo
    {
        public int Id { get; set; }
        public string nombre { get; set; } = "";
        public string descripcion { get; set; } = "";
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string categoria { get; set; } = "";
        public int categoriaId { get; set; }
    }
}
