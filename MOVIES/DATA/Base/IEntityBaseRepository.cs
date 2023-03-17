using MOVIES.Models;

namespace MOVIES.DATA.Base
{
	public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
	{
		Task<IEnumerable<T>> GetAllActorsAsync();
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T entity);
		Task UpdateAsync(int id, T entity);
		Task DeleteAsync(int id);
	}
}
