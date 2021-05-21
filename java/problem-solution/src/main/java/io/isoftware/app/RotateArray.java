package io.isoftware.app;

public class RotateArray {

    public static void rotate(int[] nums, int k) {
        k %= nums.length;
        reverse(nums, 0, nums.length - 1);
        reverse(nums, 0, k - 1);
        reverse(nums, k, nums.length - 1);
        return;
    }

    public static void reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }

        return;
    }

    public static void reverse(int[] inputArray){
        if(inputArray.length <= 1){
            return;
        }

        for(int first = 0, last = inputArray.length -1 ; first < last; first++, last--){
            int tmp = inputArray[first];
            inputArray[first] = inputArray[last];
            inputArray[last] = tmp;
        }

        return;
    }
}
