﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    //You are given an array prices where prices[i] is the price of a given stock on the ith day.

    //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

    //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    class MaxProfitProblem
    {
        public int MaxProfit(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }

            return maxprofit;
        }
    }
}
