using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    class LemonadeStandCorporation
    {
        public int numberOfLocation { get; set; }
        public decimal totalRevenue { get; set; }
        public decimal totalExpenses { get; set; }
        public decimal totalProfit { get; set; }
        public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();

        public decimal GetTotalRevenueOfStands()
        {
            totalRevenue = 0;
            foreach(LemonadeStand location in Locations)
            {
                totalRevenue += location.GetTotalRevenue();
            }

            return totalRevenue;
        }

        public decimal GetTotalExpensesOfStands()
        {
            return Locations.Sum(x => x.GetTotalExpenses());
        }

        public decimal GetTotalProfitOfStands()
        {
            return GetTotalRevenueOfStands() - GetTotalExpensesOfStands();
        }

    }
}
