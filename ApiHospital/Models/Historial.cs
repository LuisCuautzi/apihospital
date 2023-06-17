using System;
using System.ComponentModel.DataAnnotations;

namespace ApiHospital.Models
{
    public class Historial
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Id es Requerido")]
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
    }
}
