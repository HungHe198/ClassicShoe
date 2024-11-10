using Azure.Messaging;
using ClassicShoe.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Repositories
{
    public class AllRepositories<N> : IAllRepositories<N> where N : class
    {
        ClassicShoeDbContext _db;
        DbSet<N> _dbSet;

        public AllRepositories(ClassicShoeDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<N>();
        }

        public bool Create(N entity)
        {
            try
            {
                _dbSet.Add(entity);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var findEntity = _dbSet.Find(id);
                if (findEntity != null)
                {
                    _dbSet.Remove(findEntity);
                    _db.SaveChanges();
                }
                return true;
            }
            catch { return false; }
        }

        public List<N> GetAll()
        {
            return _dbSet.ToList();
        }

        public N GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public bool Update(Guid id, N entity)
        {
            try
            {
                var findEntity = _dbSet.Find(id);
                if (findEntity != null)
                {
                    _dbSet.Update(entity);
                    _db.SaveChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
