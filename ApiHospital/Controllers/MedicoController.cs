using ApiHospital.Data;
using ApiHospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiHospital.Controllers
{
    [ApiController]
    [Route("api/medico")]
    public class MedicoController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public MedicoController(AplicationDbContext context)
        {
            _context = context;
        }

        //Metodo GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medico>>> GetListMedico()
        {
            var listaMedico = await _context.Medicos.ToListAsync();
            return listaMedico;
        }

        //Metodo GET  por id
        [HttpGet]
        public async Task<ActionResult<Medico>> GetMedicoById(int id)
        {
            var medicos = await _context.Medicos.FirstOrDefaultAsync(a => a.Id == id);
            if(medicos == null)
            {
                return NotFound("Medico no encontrado");
            }
            return medicos;
        }


    }
}
