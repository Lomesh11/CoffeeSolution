using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.RepositoryData
{
    public interface IRepository
    {
        List<Inventory> getData();
        void upDateInventory(string invType, int qty);
    }
}
