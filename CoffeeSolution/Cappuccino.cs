using System;

namespace CoffeeSolution
{
    public class Cappuccino : Drink
    {
        public override void makeDrink(bool milk)
        {
            Console.WriteLine("Cappuccino is ready..!!!");
        }
    }
}
