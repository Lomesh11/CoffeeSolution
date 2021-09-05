﻿using Coffee.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Business
{
    public abstract class Machine
    {
        protected abstract Drink CreateDrink();
        public Drink GetDrink()
        {
            return this.CreateDrink();
        }
    }
}
