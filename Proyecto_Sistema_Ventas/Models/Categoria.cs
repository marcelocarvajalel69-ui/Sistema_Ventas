using System.ComponentModel.DataAnnotations;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Categoria
    {
        [Key]
        public int id_Categoria { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;

        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}