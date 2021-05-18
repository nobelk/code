package io.isoftware.app;

import org.junit.Test;
import org.junit.Assert;

public class TestSingleNumber {

    @Test
    public void TestSingleNumber(){
        int[] nums = {4, 1, 4, 2, 1, 2, 5};
        Assert.assertEquals(5, SingleNumber.singleNumber(nums));

        int[] nums1 = {4};
        Assert.assertEquals(4, SingleNumber.singleNumber(nums1));

        Assert.assertEquals(10000, SingleNumber.singleNumber(new int[]{100, 100, 10000}));
    }
}
