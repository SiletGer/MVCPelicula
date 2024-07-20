using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula.Models
{
    public class Pelicula
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "El campo Título es requerido")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }


        [Display(Name = "Fecha de Lanzamiento")]
        [Required(ErrorMessage = "El dato de Fecha de lanzamiento es requerido")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [Required]
        [ForeignKey("Genero")]
        [Display(Name = "Género")]
        public int? GeneroId { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "El dato Director es requerido")]

        public string Director {  get; set; }

        [Required(ErrorMessage = "El dato de la Sala es requerido")]

        public string Sala { get; set; }

        public Genero Genero { get; set; }
    }
}
