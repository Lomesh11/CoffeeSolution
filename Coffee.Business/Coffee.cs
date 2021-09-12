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
            try
            {
                Console.WriteLine("Would you like milk or not?[Y/N]");
                string userInput = Console.ReadLine();
                IDataAccess _dataAccess = new DataAccess.DataAccess();
                int reqMilkQty = 1;
                int reqBeansQty = 2;
                if (_dataAccess.IsBeanAvailable(reqBeansQty) && _dataAccess.isMIlkAvailable(reqMilkQty))
                {
                    _dataAccess.UpdateInventory("Beans",reqBeansQty);
                    _dataAccess.UpdateInventory("Milk", reqMilkQty);
                    Console.WriteLine("\n*********************\nCoffee is ready..!!!\n*********************\n");
                }
                else
                {
                    Console.WriteLine("Insufficient milk or beans units to make coffee..!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong ", ex.Message);
            }
           
        }
    }
}
