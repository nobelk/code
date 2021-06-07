package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestRotateMatrix {

    @Test
    public void TestRotation(){
        int[][] matrix = {{1,2,3},{4,5,6},{7,8,9}};
        RotateMatrix rmat = new RotateMatrix();
        rmat.rotate(matrix);
        Assert.assertArrayEquals(matrix[0], new int[]{7,4, 1});
        Assert.assertArrayEquals(matrix[1], new int[]{8,5,2});
        Assert.assertArrayEquals(matrix[2], new int[]{9,6,3});
    }
}
