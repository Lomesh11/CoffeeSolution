using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.DataAccess
{
    public interface IDataAccess
    {
        bool isMIlkAvailable(int milkQty);
        bool IsBeanAvailable(int beansQty);
        void UpdateInventory(string drinkType, int Qty);
    }
}
