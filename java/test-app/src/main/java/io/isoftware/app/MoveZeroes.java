package io.isoftware.app;

public class MoveZeroes {
    public static void moveZeroes(int[] nums){
        int lastNonZeroFoundAt = 0;
        // append non-zero current element to +1 index of the last non-zero element
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] != 0) {
                nums[lastNonZeroFoundAt++] = nums[i];
            }
        }

        // all non-zero elements are at the front of array, rest of the positions will be zero
        for (int i = lastNonZeroFoundAt; i < nums.length; i++) {
            nums[i] = 0;
        }
    }
}
