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

        public AllRepositories(ClassicShoeDbContext db, DbSet<N> dbSet)
        {
            _db = db;
            _dbSet = dbSet;
        }

        public bool Create(N entity)
        {
            try { return true; }
            catch { return false; }
        }

        public bool Delete(Guid id)
        {
            try { return true; }
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
            try { return true; }
            catch { return false; }
        }
    }
}
