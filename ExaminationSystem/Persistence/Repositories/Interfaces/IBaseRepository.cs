using System.Linq.Expressions;

namespace ExaminationSystem.Persistence.Repositories.Interfaces;

public interface IBaseRepository<T> where T : BaseAuditableEntity
{
    Task<IReadOnlyList<T>> GetListAsync(bool withNoTracking = true);
    Task<T?> GetAsync(int id);
    Task<T?> GetWithDetailsAsync(Expression<Func<T, bool>> predicate, string[]? includes = null);
    Task<T> AddAsync(T entity);
    Task<bool> UpdateAsync(int id, T entity);
    Task<bool> RemoveAsync(int id);
    Task<bool> HardRemoveAsync(int id);
    //Task<PaginatedList<T>> GetPagedListAsync(int pageNumber, int pageSize);

}