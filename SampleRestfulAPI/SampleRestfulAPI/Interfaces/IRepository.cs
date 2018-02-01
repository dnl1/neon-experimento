using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleRestfulAPI.Interfaces
{
    public interface IRepository<T> where T : IModel
    {
        T Get(int id);
        T Create(T entity);
        void Delete(int id);
        T Update(T entity);
        IEnumerable<T> GetAll();
    }
}