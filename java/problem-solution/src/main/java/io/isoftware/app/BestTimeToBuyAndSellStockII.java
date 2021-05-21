package io.isoftware.app;

public class BestTimeToBuyAndSellStockII {

    public static int maxProfit(int[] prices) {
        int maxProfit = 0;
        for (int index = 1; index < prices.length; index++) {
            if (prices[index-1] < prices[index]) {
                maxProfit += prices[index] - prices[index-1];
            }
        }
        return maxProfit;
    }
}