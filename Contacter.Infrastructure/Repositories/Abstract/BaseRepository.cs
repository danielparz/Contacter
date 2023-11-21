using Contacter.Domain.Interfaces.Common;
using Contacter.Domain.Models.Common;
using Contacter.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure.Repositories.Abstract
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected readonly Context _context;
        private DbSet<T> dbSet;

        public BaseRepository(Context context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public int AddObject(T entity)
        {
            dbSet.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public T? GetObjectById(int id)
        {
            return dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteObject(int id)
        {
            var obj = dbSet.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                dbSet.Remove(obj);
                _context.SaveChanges();
            }
        }

        public int UpdateObject(T entity)
        {
            var temp = dbSet.FirstOrDefault(x => x.Id == entity.Id);
            if (temp != null)
            {
                temp = entity;
                _context.SaveChanges();
            }
            return entity.Id;
        }
    }
}
