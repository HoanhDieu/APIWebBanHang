﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TrangThaiRequest : BaseRequest
    {
        public int DatHangId { get; set; }
        public int StatusId { get; set; }
    }
}
