package io.isoftware.app;

import org.junit.Test;
import static org.junit.Assert.*;

public class TestRotateArray {

    @Test
    public void TestReverseArray(){
        int [] arr = {10, 20, 30, 40, 50};
        RotateArray.reverse(arr);
        int [] exp = {50, 40, 30, 20, 10};
        assertArrayEquals(exp, arr);
    }

    @Test
    public void TestRotateArray() {
        int[] nums = {1, 2, 3, 4, 5, 6, 7};
        int[] nums1 = {-1,-100,3,99};

        int k = 3;
        RotateArray.rotate(nums, k);

        k=2;
        RotateArray.rotate(nums1, k);

        assertArrayEquals(new int[]{5, 6, 7, 1, 2, 3, 4}, nums);
        assertArrayEquals(new int[]{3,99,-1,-100}, nums1);
    }
}
