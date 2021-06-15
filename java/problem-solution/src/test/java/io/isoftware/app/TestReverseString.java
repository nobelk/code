package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestReverseString {

    @Test
    public void TestReversal(){
        ReverseString rv = new ReverseString();
        char[] s = {'h','e','l','l','o'};
        rv.reverseString(s);

        Assert.assertArrayEquals(new char[]{'o', 'l', 'l', 'e', 'h'}, s);
    }
}
