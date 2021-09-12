using System.Linq;
using Coffee.RepositoryData;

namespace Coffee.DataAccess
{
    /// <summary>
    /// Data access layer
    /// </summary>
    public  class DataAccess : IDataAccess
    {
        public string warningMessage;
        IRepository _repo;
       
        /// <summary>
        /// check milk is available or not
        /// </summary>
        /// <returns></returns>
        public bool isMIlkAvailable(int reqMilkQty)
        {
            _repo = new InventoryData();
            var milkQty = _repo.getData().Where(m => m.InventoryType == "Milk").FirstOrDefault().UnitRemaining;
            var isBeanAvailable = reqMilkQty <= milkQty;
            if (!isBeanAvailable)
            {
                warningMessage = $"Machine is running low on Milk";
            }
            return isBeanAvailable;
        }

        /// <summary>
        /// check beans are available or not
        /// </summary>
        /// <returns></returns>
        public bool IsBeanAvailable(int reqBeansQty)
        {
            _repo = new InventoryData();
            var beanQty = _repo.getData().Where(m => m.InventoryType == "Beans").FirstOrDefault().UnitRemaining;
            var isBeanAvailable = reqBeansQty <= beanQty;
            if (!isBeanAvailable)
            {
                warningMessage = $"Machine is running low on Beans";
            }
            return isBeanAvailable;
        }

        public void UpdateInventory(string drinkType,int Qty)
        {
            _repo = new InventoryData();
            _repo.upDateInventory(drinkType, Qty);
        }
    }
}
