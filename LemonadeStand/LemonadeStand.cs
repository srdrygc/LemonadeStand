using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class LemonadeStand
    {
        public int NumberOfStand { get; set; }
        public string Name { get; set; }
        public int NumberOfCups { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }

        public decimal GetTotalRevenue()
        {
            return NumberOfCups * PricePerCup;
        }
    }
}
