﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    public class OrderResponse
    {
        public string ResponseMessage { get; set; }

        public ReceivedOrder OrderForResponse { get; set; }
    }
}
