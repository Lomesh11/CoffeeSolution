using Coffee.Interface;
using System;
using Coffee.RepositoryData;

namespace Coffee.Business
{
    /// <summary>
    /// Implement Cappuccino functionality
    /// </summary>
    class Cappuccino : IDrink
    {
        public void MakeDrink()
        {
            Console.WriteLine("Please provide sugar quantity.");
            int milkUnits = InMemoryData.getMilkCount();
            int beanUnits = InMemoryData.getBeansCount();
            if (milkUnits > 2 && beanUnits > 4)
            {
                Console.WriteLine("Cappuccino is ready..!!!");
            }
            else 
            {
                Console.WriteLine("Insufficient milk or beans units to make Cappuccino..!!!");
            }
        }
    }
}
