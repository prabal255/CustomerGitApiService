﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApiService.Models
{
    public class Customer
    {
       
            public int CustomerId
            {
                get;
                set;
            }
            public string CustomerName
            {
                get;
                set;
            }
            public string Address
            {
                get;
                set;
            }
            public string State
            {
                get;
                set;
            }
        }
}
