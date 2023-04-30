using System.ComponentModel.DataAnnotations;

namespace practicaMVC2.Models
{
    public class marcas
    {
        [Key]
        [Display(Name ="ID")]
        public int id_marcas { get; set; }
        [Display(Name = "Nombre de las Marcas")]
        public string? nombre_marca { get; set; }
        [Display(Name = "Estado")]
        public string? estados { get; set; }
    }
}
