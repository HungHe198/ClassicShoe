﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class MauSac
    {
        public Guid Id { get; set; }
        public ICollection<GiayChiTiet>? GiayChiTiets { get; set; }
        public string TenMau { get; set; }
    }
}
