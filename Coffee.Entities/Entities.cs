using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Entities
{
    /// <summary>
    /// Entities for the coffee solution
    /// </summary>
    public class Entities
    {
        public int COffeeBeansQty { get; set; }
        public int MilkQty { get; set; }

        public enum SelectDrink
        {
            Coffee = 1,
            Latte = 2,
            Cappuccino = 3
        }
    }
}
