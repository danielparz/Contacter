using Contacter.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Interfaces.Common
{
    public interface IBaseRepository<T> where T : Entity
    {
        T? GetObjectById(int id);
        int AddObject(T entity);
        void DeleteObject(int id);
        IQueryable<T> GetAllActive();
        IQueryable<T> GetAll();
        int UpdateObject(T entity);
    }
}
