using Coffee.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Business
{
    public abstract class Machine
    {
        protected abstract IDrink CreateDrink();
        public IDrink GetDrink()
        {
            return this.CreateDrink();
        }
    }
}
