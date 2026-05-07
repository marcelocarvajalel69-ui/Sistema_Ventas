using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Detalle_Pedido
    {
        [Key]
        public int id_Detalle { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        public int id_Pedido { get; set; }

        [ForeignKey("id_Pedido")]
        public Pedido Pedido { get; set; } = null!;

        public int id_Producto { get; set; }

        [ForeignKey("id_Producto")]
        public Producto Producto { get; set; } = null!;
    }
}