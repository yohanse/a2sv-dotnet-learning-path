using Application;
using Microsoft.EntityFrameworkCore;

namespace Persistence;


public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly HrLeaveManagmentDbContext _HrLeaveManagmentDbContext;
    public GenericRepository(HrLeaveManagmentDbContext hrLeaveManagmentDbContext)
    {
        _HrLeaveManagmentDbContext = hrLeaveManagmentDbContext;
    }
    public async Task<T> Add(T entity)
    {
        await _HrLeaveManagmentDbContext.AddAsync(entity);
        await _HrLeaveManagmentDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(T entity)
    {
        _HrLeaveManagmentDbContext.Set<T>().Remove(entity);
        await _HrLeaveManagmentDbContext.SaveChangesAsync();

    }

    public async Task<bool> Exists(int id)
    {
        var entity = await Get(id);
        return entity != null;
    }

    public async Task<T> Get(int id)
    {
        return await _HrLeaveManagmentDbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> GetAll()
    {
        return await _HrLeaveManagmentDbContext.Set<T>().ToListAsync();
    }

    public async Task Update(T entity)
    {
        _HrLeaveManagmentDbContext.Entry(entity).State = EntityState.Modified;
        await _HrLeaveManagmentDbContext.SaveChangesAsync();
    }
}