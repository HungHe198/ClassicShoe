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
            if (maGiamGia.NgayBatDau >= maGiamGia.NgayKetThuc)
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.");
            if (maGiamGia.NgayBatDau < DateTime.Now)
                throw new ArgumentException("Ngày bắt đầu không thể nhỏ hơn ngày hiện tại.");
            if (maGiamGia.PhanTramGiam < 0 || maGiamGia.PhanTramGiam > 100)
                throw new ArgumentException("Phần trăm giảm phải nằm trong khoảng 0-100.");
            return _repository.Create(maGiamGia);
        }

        public bool UpdateMaGiamGia(Guid id, MaGiamGia maGiamGia)
        {
            if (maGiamGia.NgayBatDau >= maGiamGia.NgayKetThuc)
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.");
            if (maGiamGia.NgayBatDau < DateTime.Now)
                throw new ArgumentException("Ngày bắt đầu không thể nhỏ hơn ngày hiện tại.");
            if (maGiamGia.PhanTramGiam < 0 || maGiamGia.PhanTramGiam > 100)
                throw new ArgumentException("Phần trăm giảm phải nằm trong khoảng 0-100.");
            return _repository.Update(id, maGiamGia);
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
