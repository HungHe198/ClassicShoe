using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Repositories
{
    public interface IAllRepositories<H> where H : class
    {
        public List<H> GetAll(); 
        public H GetById(Guid id);
        public bool Create(H entity);
        public bool Update(Guid id,  H entity);
        public bool Delete(Guid id);
    }
}
