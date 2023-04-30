using System.ComponentModel.DataAnnotations;

namespace practicaMVC2.Models
{
    public class estados_reservas
    {
        [Key]
        public int estado_res_id { get; set; }
        public string? estado { get; set; }
    }
}
