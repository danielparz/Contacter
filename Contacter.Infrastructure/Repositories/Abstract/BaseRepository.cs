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
        private DbSet<T> _dbSet;

        public BaseRepository(Context context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public int AddObject(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public IQueryable<T> GetAllActive()
        {
            return _dbSet.Where(x => !x.IsDeleted);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T? GetObjectById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteObject(int id)
        {
            var obj = _dbSet.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                _dbSet.Remove(obj);
                _context.SaveChanges();
            }
        }

        public int UpdateObject(T entity)
        {
            var temp = _dbSet.FirstOrDefault(x => x.Id == entity.Id);
            if (temp != null)
            {
                temp = entity;
                _context.SaveChanges();
            }
            return entity.Id;
        }
    }
}
