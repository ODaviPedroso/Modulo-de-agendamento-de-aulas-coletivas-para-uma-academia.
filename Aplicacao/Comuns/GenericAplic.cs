using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Comuns
{
    public abstract class GenericAplic<TEntity> : IGenericAplic<TEntity> where TEntity : BaseEntity
    {
        private readonly IGenericRepository<TEntity> _repository;

        protected GenericAplic(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task CreateAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
        }

        public virtual async Task UpdateAsync(int id, TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                _repository.Delete(entity);
            }
        }
    }
}
