using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Cliente
    {
        [Key]
        [ForeignKey("Usuario")]
        public int id_Usuario { get; set; }

        [MaxLength(255)]
        public string? Direccion { get; set; }

        public Usuario Usuario { get; set; } = null!;
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}