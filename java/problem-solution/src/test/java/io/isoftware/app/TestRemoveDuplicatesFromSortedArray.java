package io.isoftware.app;

import org.junit.Test;
import static org.junit.Assert.*;

public class TestRemoveDuplicatesFromSortedArray {

    @Test
    public void TestRemoveDuplicates(){
        int[] inputArray = new int[]{ 2, 5, 5, 6, 6, 6, 6, 78, 988, 988, 1000 };
        assertEquals(6, RemoveDuplicatesFromSortedArray.removeDuplicates(inputArray));
    }
}