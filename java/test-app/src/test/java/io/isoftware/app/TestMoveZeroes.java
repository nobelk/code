package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestMoveZeroes {

    @Test
    public void TestSolution(){
        int[] nums = new int[]{0};
        MoveZeroes.moveZeroes(nums);
        Assert.assertArrayEquals(new int[]{0}, nums);

        nums = new int[]{0, 1, 2, 3, 55};
        MoveZeroes.moveZeroes(nums);
        Assert.assertArrayEquals(new int[]{1, 2, 3, 55, 0}, nums);

        nums = new int[]{0, 1, 1, 1, 1, 1};
        MoveZeroes.moveZeroes(nums);
        Assert.assertArrayEquals(new int[]{1, 1, 1, 1, 1, 0}, nums);
    }
}
