using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Entities
{
    public static class DrinkEntities
    {
        public static int reqBeansQty { get; set; }
        public static int reqMilkQty { get; set; }
        public static DrinkType drinkType { get; set; }
    }

    public enum DrinkType
    { 
        Coffee,
        Latte,
        Cappuccino
    }
}
