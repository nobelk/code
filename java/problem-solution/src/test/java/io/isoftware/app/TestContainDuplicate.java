package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestContainDuplicate {

    @Test
    public void TestContainDuplicate(){
        int[] nums = {1,1,1,3,3,4,3,2,4,2};
        Assert.assertTrue(ContainsDuplicate.containsDuplicate(nums));
        Assert.assertFalse(ContainsDuplicate.containsDuplicate(new int[]{1, 2, 3, 43}));
    }
}
