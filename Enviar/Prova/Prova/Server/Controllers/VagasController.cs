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
    public class VagasController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public VagasController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Vagas>>> Get()
        {
            return await _db.Vagas.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById3")]
        public async Task<ActionResult<Vagas>> GetById(int id)
        {
            return await _db.Vagas.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Vagas vagas)
        {
            _db.Entry(vagas).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}", Name = "GetByIdVagas")]
        public async Task<ActionResult<Vagas>> GetByIdVagas(int id)
        {
            _db.Entry(id).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();

            return await _db.Vagas.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Vagas vagas)
        {
            _db.Add(vagas);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetById), new { vagas.Id }, vagas);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var vagas = await _db.Vagas.FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(vagas);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}
