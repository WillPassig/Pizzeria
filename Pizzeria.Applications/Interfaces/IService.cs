using Pizzeria.Domain.Base;
using System.Collections.Generic;

namespace Pizzeria.Applications.Interfaces
{
    internal interface IService<T> where T : Entity
    {
        long Add(T entity);
        void Update();
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
