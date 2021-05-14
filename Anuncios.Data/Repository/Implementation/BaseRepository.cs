using Anuncios.Data.Repository.Interface;
using Anuncios.Domain.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Anuncios.Data.Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        protected readonly Context _context;

        public BaseRepository(Context context)
        {
            _context = context;
        }

        public virtual List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Get(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            var result = Get(entity.Id);
            if (result == null)
                return null;

            _context.Entry(result).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
