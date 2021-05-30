using GenericCRUDApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericCRUDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericCRUDController<T> : ControllerBase where T:EntityBase
    {
        protected readonly DataContext _context;

        public GenericCRUDController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public virtual async Task<IActionResult> List()
        {
            var list = await _context.Set<T>().ToListAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Detail(long id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null )
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(T entity)
        {
            entity.EntryDate = DateTime.Now;
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Detail", new { id = entity.Id }, entity);
        }

        [HttpPut]
        public virtual async Task<IActionResult> Update(long id, T entity)
        {
            if (id != entity.Id )
            {
                return BadRequest();
            }
            if (!await EntityExists(id))
            {
                return NotFound();
            }

            entity.UpdateDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return NoContent();

        }

        private Task<bool> EntityExists(long id)
        {
            return _context.Set<T>().AnyAsync(e => e.Id == id);
        }
    }
}
