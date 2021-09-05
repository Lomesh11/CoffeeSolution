using Coffee.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Business.Factory
{
    public class LatteFactory : Machine
    {
        protected override Drink CreateDrink()
        {
            Drink drink = new Latte();
            return drink;
        }
    }
}
