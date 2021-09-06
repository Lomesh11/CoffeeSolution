using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.RepositoryData
{
    public class Inventory
    {
        public object InventoryId { get; set; }
        public string InventoryType { get; set; }
        public int InitialUnit { get; set; }
        public int UnitRemaining { get; set; }

    }

    public enum InventoryType
    { 
        Beans,
        Milk,
        Sugar
    }
}
