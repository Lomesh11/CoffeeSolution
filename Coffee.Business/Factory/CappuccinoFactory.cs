﻿using Coffee.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Business.Factory
{
    public class CappuccinoFactory : Machine
    {
        protected override Drink CreateDrink()
        {
            Drink drink = new Cappuccino();
            return drink;
        }
    }
}