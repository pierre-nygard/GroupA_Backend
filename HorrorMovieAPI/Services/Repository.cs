using System.Threading.Tasks;
using HorrorMovieAPI.DB_Context;
using HorrorMovieAPI.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace HorrorMovieAPI.Services
{
    public class Repository<T, TContext> : IRepository<T>
    where T : class, IEntity
    where TContext : DbContext
    {
        private readonly HorrorContext _context;
        private readonly ILogger _logger;

        public Repository(HorrorContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }
            _context.Set<T>().Remove(entity);
            await Save();
            return entity;
        }

        public async Task<T> Get(int id)
        {
            _logger.LogInformation($"Getting object with id {id}");
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0; ;
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await Save();
            return entity;
        }
    }
}