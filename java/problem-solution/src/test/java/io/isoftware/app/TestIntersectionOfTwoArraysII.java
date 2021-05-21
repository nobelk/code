package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestIntersectionOfTwoArraysII {

    @Test
    public void TestSolution(){

        int[] nums1 = {1,2,2,1};
        int[] nums2 = {2,2};

        Assert.assertArrayEquals(
                new int[]{2, 2},
                IntersectionOfTwoArraysII.findIntersection(
                        nums1,
                        nums2));
        Assert.assertArrayEquals(
                new int[]{9, 4},
                IntersectionOfTwoArraysII.findIntersection(
                        new int[]{4, 9, 5},
                        new int[]{9, 4, 9, 8, 4}));
    }
}
