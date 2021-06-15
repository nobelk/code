package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestValidAnagram {
    @Test
    public void anagramTest(){
        ValidAnagram va = new ValidAnagram();
        Assert.assertTrue(va.isAnagram("anagram", "nagaram"));
    }
}
