﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.BUS_Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IQLNhapKho
    {
        public List<NhapKho> NhapKhos();
    }
}
