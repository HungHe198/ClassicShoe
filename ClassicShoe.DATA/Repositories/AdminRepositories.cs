using ClassicShoe.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Repositories
{
    public class AdminRepositories : IAllRepositories<Admin>
    {
        public bool Create(Admin entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid id, Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
