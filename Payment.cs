﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public abstract class Payment
    {
        public int Amount;
        public Payment (int Amount)
        {
            this.Amount = Amount;

        }
    }
}
