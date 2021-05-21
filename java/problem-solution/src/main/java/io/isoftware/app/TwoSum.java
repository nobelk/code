package io.isoftware.app;

import java.util.HashMap;

public class TwoSum {

    public static int[] FindIndices (int[] nums, int target){

        int[] result = new int[2];
        HashMap<Integer, Integer> store = new HashMap<>(nums.length);

        for(int index = 0; index<nums.length; index++){
            store.put(target-nums[index], index);
        }

        for(int index = 0; index<nums.length; index++){
            if(store.containsKey(nums[index])){
                result[0] = index;
                result[1] = store.get(nums[index]);
                return result;
            }
        }

        throw new IllegalArgumentException("No solution");
    }
}
