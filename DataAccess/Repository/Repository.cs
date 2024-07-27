using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using DataAccess.Repository.IRepository;
using System.Linq.Expressions;


namespace DataAccess.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    internal DbSet<T> dbSet; 
    public Repository(ApplicationDbContext context)
    {
        _context = context;
        dbSet = _context.Set<T>();
        //_context.Products.Include(p => p.Category);
    }
    public void Add(T entity)
    {
        dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        dbSet.Remove(entity);
    }

    public void DeleteRange(IEnumerable<T> entity)
    {
        dbSet.RemoveRange(entity);
    }

    public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
        IQueryable<T> query = dbSet;
        query = query.Where(filter);

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var property in includeProperties
                         .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(property);
            }
        }

        return query.FirstOrDefault();
    }

    public IEnumerable<T> GetAll(string? includeProperties = null)
    {
        IQueryable<T> query = dbSet;
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var property in includeProperties
                         .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(property);
            }
        }
        return query.ToList();
    }

}
