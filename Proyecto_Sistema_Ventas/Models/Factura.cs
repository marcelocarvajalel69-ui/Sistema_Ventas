using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Factura
    {
        [Key]
        public int id_Factura { get; set; }

        [Required]
        [MaxLength(50)]
        public string Numero_Factura { get; set; } = null!;

        [Required]
        public DateTime Fecha_Emision { get; set; } = DateTime.Now;

        [Required]
        public decimal Total { get; set; }

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; } = "emitida";

        public int id_Pedido { get; set; }

        [ForeignKey("id_Pedido")]
        public Pedido Pedido { get; set; } = null!;
    }
}