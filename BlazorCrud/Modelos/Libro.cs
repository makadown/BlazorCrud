using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCrud.Modelos
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor capture el Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Por favor capture la Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Por favor capture el Autor")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Por favor capture la cantidad de páginas")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "Por favor capture el Precio")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
