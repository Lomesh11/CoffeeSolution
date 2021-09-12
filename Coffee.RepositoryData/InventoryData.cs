using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffee.RepositoryData
{
    public  class InventoryData:IRepository
    {
        /// <summary>
        /// Get inventory details
        /// </summary>
        /// <returns></returns>
        public List<Inventory> getData()
        {
            List<Inventory> _inventories = new List<Inventory>();
            using (Coffee_DBEntities context=new Coffee_DBEntities())
            {
               
                var data = context.tbl_Inventory.ToList();
                foreach (var item in data)
                {
                    Inventory inv = new Inventory();
                    inv.InventoryId = item.id;
                    inv.InventoryType = item.inventoryType;
                    inv.InitialUnit = Convert.ToInt32(item.initialQty);
                    inv.UnitRemaining = Convert.ToInt32(item.remainingQty);
                    _inventories.Add(inv);
                }
            }
            return _inventories;
        }

        /// <summary>
        /// update inventory details
        /// </summary>
        /// <param name="invType"></param>
        /// <param name="qty"></param>
        public void upDateInventory(string invType,int qty)
        {
            using (var context=new Coffee_DBEntities())
            {
                var data = context.tbl_Inventory.Where(m => m.inventoryType.ToLower() == invType.ToLower()).FirstOrDefault();
                data.remainingQty = data.remainingQty - qty;
                context.SaveChanges();
            }        
        }
    }
}
