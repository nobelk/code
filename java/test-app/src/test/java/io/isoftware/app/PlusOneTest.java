package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class PlusOneTest {

    @Test
    public void TestPlusOne(){
        Assert.assertArrayEquals(new int[]{1}, PlusOne.plusOne(new int[]{0}));
        Assert.assertArrayEquals(new int[]{2}, PlusOne.plusOne(new int[]{1}));
        Assert.assertArrayEquals(new int[]{4, 3, 2, 2}, PlusOne.plusOne(new int[]{4, 3, 2, 1}));
        Assert.assertArrayEquals(new int[]{1, 2, 4}, PlusOne.plusOne(new int[]{1, 2, 3}));
    }
}
