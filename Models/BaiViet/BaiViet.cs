﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaiViet :BaseModels
    {
        public string TenBaiViet {  get; set; }
        public string ThongTin { get; set; }
        public string GroupFile   { get; set; }
        public string MoTa { get; set; }
        public bool IsActive { get; set; }

    }
}
