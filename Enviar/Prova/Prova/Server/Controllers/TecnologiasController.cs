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
    public class TecnologiasController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public TecnologiasController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Tecnologias>>> Get()
        {
            return await _db.Tecnologias.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById2")]
        public async Task<ActionResult<Tecnologias>> GetById(int id)
        {
            return await _db.Tecnologias.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Tecnologias tecnologias)
        {
            _db.Entry(tecnologias).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}", Name = "GetByIdTecnologia")]
        public async Task<ActionResult<Tecnologias>> GetByIdTecnologia(int id)
        {
            _db.Entry(id).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();

            return await _db.Tecnologias.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Tecnologias tecnologias)
        {
            _db.Add(tecnologias);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetById), new { tecnologias.Id }, tecnologias);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var tecnologias = await _db.Tecnologias.FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(tecnologias);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}


