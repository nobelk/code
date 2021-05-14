package problems

func removeDuplicates(nums []int) int {

	if len(nums) <= 1 {
		return len(nums)
	}

	i := 0
	for j := 1; j < len(nums); j++ {

		if nums[i] != nums[j] {
			i++
			nums[i] = nums[j]
		}
	}

	return i + 1
}
