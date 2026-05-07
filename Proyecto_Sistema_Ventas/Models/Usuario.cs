using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Sistema_Ventas.Models
{
    public class Usuario
    {
        [Key]
        public int id_Usuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Correo { get; set; } = null!;

        [Required]
        public string Contrasena { get; set; } = null!;

        public Cliente? Cliente { get; set; }
        public Administrador? Administrador { get; set; }
    }
}