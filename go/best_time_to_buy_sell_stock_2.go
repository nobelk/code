package problems

func get_max_profit(prices []int) int {

	maxProfit := 0

	for index := 1; index < len(prices); index++ {
		if prices[index-1] < prices[index] {
			maxProfit += prices[index] - prices[index-1]
		}
	}

	return maxProfit
}
