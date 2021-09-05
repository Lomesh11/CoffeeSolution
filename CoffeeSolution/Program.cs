using Coffee.Business;
using Coffee.Interface;
using System;
using System.Configuration;
using Coffee.Entities;
using static Coffee.Entities.Entities;
using Coffee.Business.Factory;

namespace CoffeeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which drink do you want?");
            Console.WriteLine("1.Coffee\n2.Latte\n3.Cappuccino\n");
            string inputNo = Console.ReadLine();
            switch (inputNo)
            {
                case "1":
                    string value=SelectDrink.Coffee.ToString();
                    Drink coffee = new CoffeeFactory().GetDrink();
                    coffee.MakeDrink();
                    break;
                case "2":
                    Drink latte = new LatteFactory().GetDrink();
                    latte.MakeDrink();
                    break;
                case "3":
                    Drink cappiccino = new CappuccinoFactory().GetDrink();
                    cappiccino.MakeDrink();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
