﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitLine.Common.Entity
{
    public class ResponeEntity
    {
        public int ErrorCode { get; set; }

        public string Reason { get; set; }

        public object Result { get; set; }

    }
}
