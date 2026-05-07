using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Comentario
    {
        [Key]
        public int id_Comentario { get; set; }

        [Required]
        public string Texto { get; set; } = null!;

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Range(1, 5)]
        public int Calificacion { get; set; }

        public int id_Usuario { get; set; }

        [ForeignKey("id_Usuario")]
        public Cliente Cliente { get; set; } = null!;
    }
}