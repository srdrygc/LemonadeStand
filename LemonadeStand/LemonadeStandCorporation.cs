using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class LemonadeStandCorporation
    {
        public int numberOfLocation { get; set; }
        public decimal totalRevenue { get; set; }
        public decimal totalExpenses { get; set; }
        public decimal totalProfit { get; set; }

        public decimal GetTotalRevenueOfStands()
        {
            totalRevenue = 0;
            for (int i = 0; i< numberOfLocation; i++)
            {
                totalRevenue += totalRevenue;
            }
            return totalRevenue;
        }
        public decimal GetTotalExpensesOfStands()
        {
            totalExpenses = 0;
            for(int i = 0; i <numberOfLocation; i++)
            {
                totalExpenses += totalExpenses;
            }
            return totalExpenses;
        }
        public decimal GetTotalProfitOfStands()
        {
            return GetTotalRevenueOfStands() - GetTotalExpensesOfStands();
        }

    }
}
