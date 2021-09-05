using Coffee.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.RepositoryData;

namespace Coffee.Business
{
    /// <summary>
    /// Implement Latte functionality
    /// </summary>
    class Latte : IDrink
    {
        public void MakeDrink()
        {
            int milkUnits = InMemoryData.getMilkCount();
            int beanUnits = InMemoryData.getBeansCount();
            if (milkUnits > 1 && beanUnits > 2)
            {
                Console.WriteLine("Latte is ready..!!!");
            }
            else
            {
                Console.WriteLine("Insufficient milk or beans units to make Latte..!!!");
            }
        }
    }
}
