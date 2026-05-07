using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Administrador
    {
        [Key]
        [ForeignKey("Usuario")]
        public int id_Usuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nivel_Acceso { get; set; } = null!;

        public Usuario Usuario { get; set; } = null!;
    }
}