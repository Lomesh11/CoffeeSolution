using Coffee.Interface;
using System;
using Coffee.DataAccess;
using Coffee.RepositoryData;

namespace Coffee.Business
{
    /// <summary>
    /// Implement coffee functionality
    /// </summary>
    class Coffee : IDrink
    {
        public void MakeDrink()
        {
            Console.WriteLine("Would you like milk or not? Press Y or N");
            string input = Console.ReadLine();
            int milkUnits = InMemoryData.getMilkCount();
            int beanUnits = InMemoryData.getBeansCount();
            if (input == "Y" && milkUnits > 0 && beanUnits > 1)
            {
                Console.WriteLine("Coffee is ready..!!!");
            }
            else
            {
                Console.WriteLine("Insufficient milk or beans units to make coffee..!!!");
            }
        }
    }
}
