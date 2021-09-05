using System;

namespace CoffeeSolution
{
    class Latte : Drink
    {
        public override void makeDrink(bool milk)
        {
            Console.WriteLine("Latte is ready..!!!");
        }
    }
}
