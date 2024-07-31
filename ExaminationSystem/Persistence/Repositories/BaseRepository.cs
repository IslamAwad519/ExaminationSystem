using System.Linq.Expressions;

namespace ExaminationSystem.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseAuditableEntity
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
   
    public async Task<IReadOnlyList<T>> GetListAsync(bool withNoTracking = true)
    {
        if (withNoTracking)
            return await _dbSet.AsNoTracking().ToListAsync();
        else
            return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<T?> GetWithDetailsAsync(Expression<Func<T, bool>> predicate, string[]? includes = null)
    {
        IQueryable<T> query = _dbSet;

        if (includes != null && includes.Length > 0)
            foreach (var include in includes)
                query = query.Include(include);

        return await query.FirstOrDefaultAsync(predicate);
    }
    public async Task<bool> UpdateAsync(int id, T entity)
    {
        var existingEntity = await _dbSet.FindAsync(id);
        if (existingEntity == null) return false;

        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<bool> RemoveAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) return false;

        _dbSet.Remove(entity);
        entity.IsDeleted = true;
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<bool> HardRemoveAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) return false;

        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }


    //public async Task<PaginatedList<T>> GetPagedListAsync(int pageNumber, int pageSize)
    //{
    //    return await PaginatedList<T>.CreateAsync(_dbSet.AsQueryable(), pageNumber, pageSize);
    //}

}


