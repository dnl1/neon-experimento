using System.Collections;
using System.Collections.Generic;

namespace SampleRestfulAPI.Interfaces
{
    public interface IBusiness<T> where T : IModel
    {
        IRepository<T> Repository { get; set; }

        T Get(int id);
        T Create(T entity);
        void Delete(int id);
        T Update(T entity);
        void Validate(T entity, bool isNew = true);
        IEnumerable<T> GetAll();
    }
}