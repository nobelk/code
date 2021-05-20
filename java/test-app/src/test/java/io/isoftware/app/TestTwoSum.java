package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestTwoSum {
    @Test
    public void TestTwoSum(){
        Assert.assertArrayEquals(
                new int[]{0,1},
                TwoSum.FindIndices(new int[]{3,2,4}, 5));
        Assert.assertArrayEquals(
                new int[]{0,1},
                TwoSum.FindIndices(new int[]{2,8,11,15}, 10));
        Assert.assertArrayEquals(
                new int[]{0,1},
                TwoSum.FindIndices(new int[]{100,-100}, 0));
        Assert.assertArrayEquals(
                new int[]{1, 2},
                TwoSum.FindIndices(new int[]{3, 2, 4}, 6));
    }
}
