using Coffee.Business;
using Coffee.Business.Factory;
using Coffee.Interface;
using System;

namespace CoffeeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputKey;
            Console.WriteLine(UIText.WelcomeMessage);
            do
            {
                Console.WriteLine(UIText.MenuOptions);
                inputKey = Console.ReadLine();
                switch (inputKey)
                {
                    case "1":
                        IDrink coffee = new CoffeeFactory().GetDrink();
                        coffee.MakeDrink();
                        Console.WriteLine(UIText.TakeOrderAgain);
                        break;
                    case "2":
                        IDrink latte = new LatteFactory().GetDrink();
                        latte.MakeDrink();
                        Console.WriteLine(UIText.TakeOrderAgain);
                        break;
                    case "3":
                        IDrink cappiccino = new CappuccinoFactory().GetDrink();
                        cappiccino.MakeDrink();
                        Console.WriteLine(UIText.TakeOrderAgain);
                        break;
                    default:
                        Console.WriteLine(UIText.MenuOptions);
                        break;
                }
                inputKey =Console.ReadLine();
            } while (inputKey.ToLower() != "off"); // keep prompting user untill they type 'off'
        }
    }
}
