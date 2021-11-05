using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Model;

namespace PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Agendamento_servicoController : ControllerBase
    {
        private readonly PetShopContext _context;

        public Agendamento_servicoController(PetShopContext context)
        {
            _context = context;
        }

        // GET: api/Agendamento_servico
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agendamento_servico>>> GetAgendamento_servico()
        {
            return await _context.Agendamento_servico.ToListAsync();
        }

        // GET: api/Agendamento_servico/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agendamento_servico>> GetAgendamento_servico(int id)
        {
            var agendamento_servico = await _context.Agendamento_servico.FindAsync(id);

            if (agendamento_servico == null)
            {
                return NotFound();
            }

            return agendamento_servico;
        }

        // PUT: api/Agendamento_servico/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgendamento_servico(int id, Agendamento_servico agendamento_servico)
        {
            if (id != agendamento_servico.Agendamento_servicoId)
            {
                return BadRequest();
            }

            _context.Entry(agendamento_servico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Agendamento_servicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Agendamento_servico
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Agendamento_servico>> PostAgendamento_servico(Agendamento_servico agendamento_servico)
        {
            _context.Agendamento_servico.Add(agendamento_servico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgendamento_servico", new { id = agendamento_servico.Agendamento_servicoId }, agendamento_servico);
        }

        // DELETE: api/Agendamento_servico/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgendamento_servico(int id)
        {
            var agendamento_servico = await _context.Agendamento_servico.FindAsync(id);
            if (agendamento_servico == null)
            {
                return NotFound();
            }

            _context.Agendamento_servico.Remove(agendamento_servico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Agendamento_servicoExists(int id)
        {
            return _context.Agendamento_servico.Any(e => e.Agendamento_servicoId == id);
        }
    }
}
