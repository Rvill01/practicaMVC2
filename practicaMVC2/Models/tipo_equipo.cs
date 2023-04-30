using System.ComponentModel.DataAnnotations;

namespace practicaMVC2.Models
{
    public class tipo_equipo
    {
        [Key]
        [Display(Name ="ID")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Tipo de Equipos")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
