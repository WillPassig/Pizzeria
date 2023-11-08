using Pizzeria.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        long Add(T entity);
        void Update();
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
