using Coffee.Interface;
using System;
using Coffee.DataAccess;

namespace Coffee.Business
{
    /// <summary>
    /// Implement Latte functionality
    /// </summary>
    class Latte : IDrink
    {
        public void MakeDrink()
        {
            try
            {
                IDataAccess _dataAccess = new DataAccess.DataAccess();
                int reqMilkQty = 2;
                int reqBeansQty = 3;
                if (_dataAccess.IsBeanAvailable(reqBeansQty) && _dataAccess.isMIlkAvailable(reqMilkQty))
                {
                    _dataAccess.UpdateInventory("Milk",reqMilkQty);
                    _dataAccess.UpdateInventory("Beans",reqBeansQty);
                    Console.WriteLine("\n*********************\nLatte is ready..!!!\n*********************\n");
                }
                else
                {
                    Console.WriteLine("Insufficient milk or beans units to make Latte..!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong ", ex.Message);
            }
           
        }
    }
}
