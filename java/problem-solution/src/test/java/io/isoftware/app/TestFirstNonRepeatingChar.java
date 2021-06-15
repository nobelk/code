package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestFirstNonRepeatingChar {

    @Test
    public void TestFirstNonRepeatingCharFinder(){

        FirstNonRepeatingChar fc = new FirstNonRepeatingChar();

        Assert.assertTrue(0 == fc.firstUniqChar("leetcode"));
        Assert.assertTrue(2 == fc.firstUniqChar("loveleetcode"));
        Assert.assertTrue(-1 == fc.firstUniqChar("aabb"));
    }
}
