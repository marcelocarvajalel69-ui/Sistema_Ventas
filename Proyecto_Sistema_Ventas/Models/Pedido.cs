using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Pedido
    {
        [Key]
        public int id_Pedido { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; } = "pendiente";

        [Required]
        [MaxLength(50)]
        public string Tipo_Entrega { get; set; } = null!;

        public string? Direccion_Entrega { get; set; }

        public string? Nota_Personalizacion { get; set; }

        public int id_Usuario { get; set; }

        [ForeignKey("id_Usuario")]
        public Cliente Cliente { get; set; } = null!;

        public Factura? Factura { get; set; }
        public ICollection<Detalle_Pedido> Detalles { get; set; } = new List<Detalle_Pedido>();
    }
}