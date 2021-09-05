using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.RepositoryData
{
    public static class InMemoryData
    {
        public static List<Inventory> _inventories;
        static InMemoryData()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    InventoryId = Guid.NewGuid(),
                    InventoryType = "Beans",
                    InitialUnit = 25,
                    UnitRemaining = 25
                },
                new Inventory()
                {
                    InventoryId = Guid.NewGuid(),
                    InventoryType = "Milk",
                    InitialUnit = 25,
                    UnitRemaining = 25
                },
                new Inventory()
                {
                    InventoryId = Guid.NewGuid(),
                    InventoryType = "Sugar",
                    InitialUnit = 25,
                    UnitRemaining = 25
                },
            };
        }

        public static int getMilkCount()
        {
            int milkCount=_inventories.Where(m => m.InventoryType == "Milk").Select(p => p.UnitRemaining).FirstOrDefault();
            return milkCount;
        }

        public static int getBeansCount()
        {
            int beansCount = _inventories.Where(m => m.InventoryType == "Beans").Select(p => p.UnitRemaining).FirstOrDefault();
            return beansCount;
        }
    }
}
