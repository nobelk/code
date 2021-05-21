package io.isoftware.app;

import java.util.ArrayList;
import java.util.HashMap;

public class IntersectionOfTwoArraysII {

    public static int[] findIntersection(int[] nums1, int[] nums2){

        if(nums1.length ==0 || nums2.length == 0){
            return new int[]{};
        }

        HashMap<Integer, Integer> counter = new HashMap<>();

        for(int num : nums1){
            if(counter.containsKey(num)){
                counter.put(num, counter.get(num) + 1);
            } else {
                counter.put(num, 1);
            }
        }

        ArrayList<Integer> result = new ArrayList<>();
        for(int num : nums2){
            int instanceCount = counter.getOrDefault(num, 0);
            if(instanceCount > 0){
                result.add(num);
                counter.put(num, instanceCount-1);
            }
        }

        return result.stream().mapToInt(num -> num).toArray();
    }
}