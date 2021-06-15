package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestNeedleInHaystack {

    @Test
    public void TestNeedleInHaystack(){
        NeedleInHaystack niH = new NeedleInHaystack();
        Assert.assertEquals(2, niH.findNeedleInHaystack("hello", "ll"));
        Assert.assertEquals(0, niH.findNeedleInHaystack("", ""));
        Assert.assertEquals(-1, niH.findNeedleInHaystack("aaaaa", "bba"));
        Assert.assertEquals(0, niH.findNeedleInHaystack("a", "a"));
        Assert.assertEquals(2, niH.findNeedleInHaystack("abc", "c"));
    }
}
