using Coffee.Interface;
using System;
using Coffee.DataAccess;

namespace Coffee.Business
{
    /// <summary>
    /// Implement Cappuccino functionality
    /// </summary>
    class Cappuccino : IDrink
    { 
        public void MakeDrink()
        {
            try
            {
                IDataAccess _dataAccess = new DataAccess.DataAccess();
                Console.WriteLine("\nEnter Sugar Cube Required[Number].");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int reqBeansQty = 5;
                int reqMilkQty = 3;
                if (_dataAccess.IsBeanAvailable(reqBeansQty) && _dataAccess.isMIlkAvailable(reqMilkQty))
                {
                    _dataAccess.UpdateInventory("Beans", reqBeansQty);
                    _dataAccess.UpdateInventory("Milk",reqMilkQty);
                    Console.WriteLine("\n*********************\nCappuccino is ready..!!!\n*********************\n");
                }
                else
                {
                    Console.WriteLine("Insufficient milk or beans units to make Cappuccino..!!!");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went wrong ", ex.Message);
            }
        }
    }
}
