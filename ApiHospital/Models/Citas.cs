﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHospital.Models
{
    public class Citas
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Id es Requerido")]
        public DateTime Fecha { get; set; }
        public float FechaInicio { get; set; }
        public float FechaFin { get; set; }
        public int PacienteID { get; set; }
        [ForeignKey("PacienteID")]
        public Paciente paciente { get; set; }
    }
}
