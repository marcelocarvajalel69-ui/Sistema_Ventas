using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Producto
    {
        [Key]
        public int id_Producto { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        [Required]
        public decimal Precio { get; set; }

        public string? Imagen { get; set; }

        [Required]
        public int Stock { get; set; } = 0;

        [Required]
        public bool Personalizable { get; set; } = false;

        public int id_Categoria { get; set; }

        [ForeignKey("id_Categoria")]
        public Categoria Categoria { get; set; } = null!;

        public ICollection<Detalle_Pedido> Detalles { get; set; } = new List<Detalle_Pedido>();
    }
}