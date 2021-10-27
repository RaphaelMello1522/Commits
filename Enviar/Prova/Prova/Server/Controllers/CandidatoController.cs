using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prova.Server.Data;
using Prova.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CandidatoController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Candidato>>> Get()
        {
            return await _db.Candidato.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Candidato>> GetById(int id)
        {
            return await _db.Candidato.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Candidato candidato)
        {
            _db.Entry(candidato).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}", Name = "GetByIdCandidato")]
        public async Task<ActionResult<Candidato>> GetByIdCandidato(int id)
        {
            _db.Entry(id).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();

            return await _db.Candidato.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Candidato candidato)
        {
            _db.Add(candidato);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetById), new { candidato.Id }, candidato);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var candidato = await _db.Candidato.FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(candidato);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}
