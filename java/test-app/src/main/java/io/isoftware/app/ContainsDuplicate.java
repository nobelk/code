package io.isoftware.app;

import java.util.HashMap;

public class ContainsDuplicate {

    public static boolean containsDuplicate(int[] nums){
        HashMap<Integer, Integer> store = new HashMap<>(nums.length);
        for (int num : nums){
            if(store.containsKey(num)){
                return true;
            }else {
                store.put(num, num);
            }
        }
        return false;
    }
}
