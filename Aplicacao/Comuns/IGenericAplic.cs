using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Comuns
{
    public interface IGenericAplic<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
        Task<TEntity> CreateAsync<TDto>(TDto createDto);
        Task UpdateAsync(int id, TEntity entity);
        Task DeleteAsync(int id);
    }
}
