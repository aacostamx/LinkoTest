using System.ComponentModel.DataAnnotations;

namespace LinkoTest.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        [Required]
        [Display(Name = "Nombre del libro")]
        [StringLength(70, ErrorMessage = "El nombre del libro no puede ser mayor a 70 caracteres.")]
        public string NombreLibro { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "El nombre del autor no puede ser mayor a 45 caracteres.")]
        public string Autor { get; set; }
        [StringLength(14, ErrorMessage = "El ISBN no puede ser mayor a 15 caracteres.")]
        public string ISBN { get; set; }
    }
}