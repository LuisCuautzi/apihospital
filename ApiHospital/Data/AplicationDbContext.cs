using System.Collections.Generic;
using System;
using ApiHospital.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiHospital.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Citas> Cita { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Historial> Historials { get; set; }
    }
}  
