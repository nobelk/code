package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestReverseInt {

    @Test
    public void reverse(){
        ReverseInt ri = new ReverseInt();
        Assert.assertTrue(ri.reverse(544)==445);
        Assert.assertTrue(ri.reverse(-8)==-8);
        Assert.assertTrue(ri.reverse(-808)==-808);
        Assert.assertTrue(ri.reverse(-800)==-8);
    }
}
