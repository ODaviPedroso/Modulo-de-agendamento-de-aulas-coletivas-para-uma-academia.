using Aplicacao.Comuns;
using Dominio.Comuns;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class GenericController<TEntity> : ControllerBase where TEntity : BaseEntity
    {
        private readonly IGenericAplic<TEntity> _service;

        protected GenericController(IGenericAplic<TEntity> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Create(TEntity entity)
        {
            await _service.CreateAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TEntity entity)
        {
            if (id != entity.Id) return BadRequest();
            await _service.UpdateAsync(id, entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
