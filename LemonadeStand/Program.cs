using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many stands do you want to open?");
            int numberOfStands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfStands; i++)
            {
                LemonadeStand newStand = new LemonadeStand();

                Console.WriteLine("What is the name of location " + i + "?");
                newStand.Name = Console.ReadLine();

                Console.WriteLine("How many cups will you sell in this location ");
                newStand.NumberOfCups = int.Parse(Console.ReadLine());

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
            for (int i = 1; i <= numberOfStands; i++)
            {
                LemonadeStandCorporation totalsOfStands = new LemonadeStandCorporation();
            }
            Console.WriteLine("Total revenue");
            LemonadeStandCorporation totals = new LemonadeStandCorporation();
            Console.WriteLine("Total revenue is " + totals.GetTotalRevenueOfStands());
            Console.WriteLine("Total profit is " + totals.GetTotalProfitOfStands());
            Console.WriteLine("Total expense is " + totals.GetTotalExpensesOfStands());

            Console.ReadLine();

        }
    }
}
