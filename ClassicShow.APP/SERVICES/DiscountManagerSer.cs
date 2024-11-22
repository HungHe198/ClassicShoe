using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.APP.SERVICES
{
    internal class DiscountManagerSer
    {
        private readonly AllRepositories<MaGiamGia> _repository;

        public DiscountManagerSer(ClassicShoeDbContext dbContext)
        {
            _repository = new AllRepositories<MaGiamGia>(dbContext);
        }

        public bool CreateMaGiamGia(MaGiamGia maGiamGia)
        {
            return _repository.Create(maGiamGia);
        }

        public bool UpdateMaGiamGia(Guid id, MaGiamGia maGiamGia)
        {
            return _repository.UpdateMGG(id, maGiamGia);
        }

        public bool DeleteMaGiamGia(Guid id)
        {
            return _repository.Delete(id);
        }

        public List<MaGiamGia> GetAllMaGiamGia()
        {
            return _repository.GetAll();
        }

        public MaGiamGia? GetMaGiamGiaById(Guid id)
        {
            return _repository.GetById(id);
        }
    }
}
