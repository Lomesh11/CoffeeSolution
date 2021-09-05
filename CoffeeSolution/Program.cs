using System;
using System.Configuration;

namespace CoffeeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which drink do you want?");
            Console.WriteLine("Coffee\nLatte\nCappuccino\n");
            string input = Console.ReadLine();

            int BeensQty = Convert.ToInt32(ConfigurationManager.AppSettings["CoffeeBeanUnits"]);
            int MilkQty = Convert.ToInt32(ConfigurationManager.AppSettings["MilkUnits"]);

            if (input.ToLower() == Constatnts.Coffee.ToLower() || input.ToLower() == Constatnts.Late.ToLower() || input.ToLower() == Constatnts.Cappuccino.ToLower())
            {
                if (input.ToLower() == Constatnts.Cappuccino.ToLower())
                {
                    Drink d = new Cappuccino();
                    Console.WriteLine("Please provide suger qty in Units?");
                    string SugarQty = Console.ReadLine();
                    d.makeDrink(true);

                }
                else if (input.ToLower() == Constatnts.Coffee.ToLower())
                {
                    Drink d = new Coffee();
                    Console.WriteLine("Would you like milk or not? Yes or No..");
                    string inputVal = Console.ReadLine();
                    bool isMilk = inputVal.ToLower() == "yes" ? true : false;
                    d.makeDrink(isMilk);
                }
                else
                {
                    Drink d = new Latte();
                    Console.Write("Make other drinks");
                    d.makeDrink(true);
                }
            }
            else
            {
                Console.WriteLine("Pleas provide the currect option?");
            }

            Console.ReadLine();
        }
    }
}
