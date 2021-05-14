using Anuncios.Domain.Interface;
using System.Collections.Generic;

namespace Anuncios.Data.Repository.Interface
{
    public interface IBaseRepository<T> where T : class, IBaseEntity
        {
            List<T> GetAll();
            T Get(int id);
            void Insert(T entity);
            T Update(T entity);
            void Delete(T entity);
        }
}
