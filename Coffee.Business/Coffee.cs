using Coffee.Interface;
using System;

namespace Coffee.Business
{
    /// <summary>
    /// Implement coffee functionality
    /// </summary>
    class Coffee : Drink
    {
        public void MakeDrink()
        {
            Console.WriteLine("Would you like milk or not? Press Y or N");
            Console.Write("Ans:" + Console.ReadLine());
            bool isMilk = Convert.ToBoolean(Console.Read());
            if (isMilk)
            {
                //check Milk qty
                //check coffee beans qty
                //make coffee
            }
            else
            {
                //make coffee without milk
            }
            //throw new NotImplementedException();
        }
    }
}
