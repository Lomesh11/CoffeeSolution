using System;

namespace CoffeeSolution
{
    class Coffee : Drink
    {
        public override void makeDrink(bool milk)
        {
            if (milk)
            {
                //coffee with milk
               // checkBeansCapacity()
                Console.WriteLine("Coffee is ready..!!!");
            }
            else
            {
                //coffee without milk
                Console.WriteLine("Coffee is ready..!!!");
            }
        }
    }
}
