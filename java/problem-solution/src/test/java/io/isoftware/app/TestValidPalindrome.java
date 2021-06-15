package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestValidPalindrome {
    @Test
    public void TestPalindrome(){
        ValidPalindrome vp = new ValidPalindrome();
        Assert.assertTrue(vp.isPalindrome("tenet"));
        Assert.assertTrue(vp.isPalindrome("Tenet"));
        Assert.assertFalse(vp.isPalindrome("text"));
        Assert.assertTrue(vp.isPalindrome("A man, a plan, a canal: Panama"));
    }
}