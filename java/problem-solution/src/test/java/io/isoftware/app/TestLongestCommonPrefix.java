package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestLongestCommonPrefix {
    @Test
    public void TestPrefixFinder(){
        LongestCommonPrefix lcp = new LongestCommonPrefix();
        Assert.assertEquals("fl", lcp.longestCommonPrefix(new String[]{"flower","flow","flight"}));
        Assert.assertEquals("", lcp.longestCommonPrefix(new String[]{"dog","racecar","car"}));

    }
}