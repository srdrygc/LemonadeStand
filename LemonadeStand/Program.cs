using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many stands do you want to open?");
            int numberOfStands = int.Parse(Console.ReadLine());

            LemonadeStandCorporation corp = new LemonadeStandCorporation();

            for (int i = 1; i <= numberOfStands; i++)
            {
                LemonadeStand newStand = new LemonadeStand();
                corp.Locations.Add(newStand);

                Console.WriteLine("What is the name of location " + i + "?");
                newStand.Name = Console.ReadLine();

                newStand.NumberOfCups = UI.GetIntegerFromUser("How many cups will you sell in this location ");

                Console.WriteLine("What is the price in this location");
                newStand.PricePerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("What is the cost in this location");

                newStand.CostPerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("This stand's total revenue will be "
                    + newStand.GetTotalRevenue());
                Console.WriteLine("This stand's total expense will be "
                    + newStand.GetTotalExpenses());

                Console.WriteLine("This stand's total profit will be "
                    + newStand.GetTotalProfit());
            }
            
            Console.WriteLine("Total revenue");
            
            Console.WriteLine("Total revenue is " + corp.GetTotalRevenueOfStands());
            Console.WriteLine("Total profit is " + corp.GetTotalProfitOfStands());
            Console.WriteLine("Total expense is " + corp.GetTotalExpensesOfStands());

            Console.ReadLine();

        }
    }
}
