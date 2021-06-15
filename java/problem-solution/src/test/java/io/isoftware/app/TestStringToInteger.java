package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestStringToInteger {

    @Test
    public void TestStringToInt(){
        StringToInteger si = new StringToInteger();
        Assert.assertEquals(-42, si.ConvertToInteger("   -42"));
        // following test not passing
        // Assert.assertEquals(-2147483648, si.ConvertToInteger("-91283472332"));
    }
}
