package problems

import "testing"

func TestBestTimeToBuySellStock2(t *testing.T) {
	expected := 7
	input := []int{7, 1, 5, 3, 6, 4}
	actual := get_max_profit(input)

	if expected != actual {
		t.Errorf("Expected: %d actual: %d", expected, actual)
	}
}
