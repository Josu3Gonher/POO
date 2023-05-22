namespace InventarioFerreteria.Models
{
    public class Compras
    {
        public int ComprasId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int ProveedorId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
