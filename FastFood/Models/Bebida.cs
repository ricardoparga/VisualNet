using System.ComponentModel.DataAnnotations;

namespace FastFood.Models
{
    public class Bebida
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre de la bebida")]
        public string Nombre { get; set; }
        public float? Precio { get; set; }
        [Display(Name = "Imagen")]
        public string? UrlImagen { get; set; }
    }
}