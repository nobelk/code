package problems

func removeDuplicates(nums []int) int {

	// use two pointers, move the first pointer along the array
	// move the second pointer only if a new element is encountered
	// return second pointer position+1
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
